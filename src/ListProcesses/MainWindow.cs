using System;
using Gtk;
using System.Diagnostics;
using System.Linq;



public partial class MainWindow: Gtk.Window
{	
string machineName;
ListStore store;
public MainWindow (): base (Gtk.WindowType.Toplevel)
{
	Build ();
	lbMachineName.Text = machineName = System.Environment.MachineName;
}

void AddColumns(TreeView treeView, string[] s){
	CellRendererText rendererText = new CellRendererText ();
	TreeViewColumn column;
	for(int i = 0;i < s.Length;i++){
		column =  new TreeViewColumn (s[i], rendererText, "text", i);
		treeView.AppendColumn (column); }
}

void CreateModel(Process[] processes){
store = new ListStore (typeof(string),
					 typeof(string));
foreach(Process p in processes){
	store.AppendValues(p.ProcessName,p.Id.ToString());
}
}

protected void OnDeleteEvent (object sender, DeleteEventArgs a)
{
Application.Quit ();
a.RetVal = true;
}

protected void OnBtnOKClicked (object sender, System.EventArgs e)
{
if(trProcessList.Columns.Length == 0){
var resp = (from p in Process.GetProcesses(machineName) 
            where p.Id > 100 
            orderby p.ProcessName ascending select p);
Process[] arrProcesses = resp.ToArray();
CreateModel(arrProcesses);
trProcessList.Model = store;
string[] arrStr = {"Process Name","Process Id"};
AddColumns(trProcessList,arrStr);
}
	
}
	
	void GetInfoSelectedItem(){
		TreePath[] selected_paths = trProcessList.Selection.GetSelectedRows ();
TreeIter iter;
int pid;
foreach (TreePath p in selected_paths)
	{
if (store.GetIter (out iter, p)) {
	pid = Convert.ToInt32(store.GetValue(iter,1));
	Process process = Process.GetProcessById(pid);
	lbVirtualMemory.Text = Convert.ToString(process.WorkingSet64 / 1024) + " Kb";
	lbPriority.Text = process.PriorityClass.ToString();
	lbStartProcessorTime.Text = process.StartTime.ToString("HH:mm:ss.ffff");
		
	}
}
	}

	protected void OnBtnInfoClicked (object sender, System.EventArgs e)
	{
		GetInfoSelectedItem();
	}
}
