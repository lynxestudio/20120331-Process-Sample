
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Label label1;
	private global::Gtk.Label lbMachineName;
	private global::Gtk.Button btnOK;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Label label2;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TreeView trProcessList;
	private global::Gtk.VBox vbox2;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Label lbInfo;
	private global::Gtk.Button btnInfo;
	private global::Gtk.HBox hbox5;
	private global::Gtk.Label label6;
	private global::Gtk.Label lbVirtualMemory;
	private global::Gtk.HBox hbox6;
	private global::Gtk.Label label5;
	private global::Gtk.Label lbPriority;
	private global::Gtk.HBox hbox7;
	private global::Gtk.Label label7;
	private global::Gtk.Label lbStartProcessorTime;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label lbOk;
	private global::Gtk.Label lbError;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Process List");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(2));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		this.hbox1.BorderWidth = ((uint)(2));
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Host: ");
		this.hbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.lbMachineName = new global::Gtk.Label ();
		this.lbMachineName.Name = "lbMachineName";
		this.lbMachineName.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
		this.hbox1.Add (this.lbMachineName);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.lbMachineName]));
		w2.Position = 1;
		w2.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.btnOK = new global::Gtk.Button ();
		this.btnOK.CanFocus = true;
		this.btnOK.Name = "btnOK";
		this.btnOK.UseUnderline = true;
		this.btnOK.Label = global::Mono.Unix.Catalog.GetString ("List Processes");
		this.hbox1.Add (this.btnOK);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnOK]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Process");
		this.hbox2.Add (this.label2);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label2]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w6.Position = 1;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.trProcessList = new global::Gtk.TreeView ();
		this.trProcessList.CanFocus = true;
		this.trProcessList.Name = "trProcessList";
		this.GtkScrolledWindow.Add (this.trProcessList);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
		w8.Position = 2;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.lbInfo = new global::Gtk.Label ();
		this.lbInfo.Name = "lbInfo";
		this.lbInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("Choose a process and press the button");
		this.hbox4.Add (this.lbInfo);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.lbInfo]));
		w9.Position = 0;
		w9.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.btnInfo = new global::Gtk.Button ();
		this.btnInfo.CanFocus = true;
		this.btnInfo.Name = "btnInfo";
		this.btnInfo.UseUnderline = true;
		// Container child btnInfo.Gtk.Container+ContainerChild
		global::Gtk.Alignment w10 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w11 = new global::Gtk.HBox ();
		w11.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w12 = new global::Gtk.Image ();
		w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-properties", global::Gtk.IconSize.Menu);
		w11.Add (w12);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w14 = new global::Gtk.Label ();
		w14.LabelProp = global::Mono.Unix.Catalog.GetString ("Get process information");
		w14.UseUnderline = true;
		w11.Add (w14);
		w10.Add (w11);
		this.btnInfo.Add (w10);
		this.hbox4.Add (this.btnInfo);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.btnInfo]));
		w18.Position = 1;
		w18.Expand = false;
		w18.Fill = false;
		this.vbox2.Add (this.hbox4);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox4]));
		w19.Position = 0;
		w19.Expand = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Homogeneous = true;
		this.hbox5.Spacing = 6;
		this.hbox5.BorderWidth = ((uint)(3));
		// Container child hbox5.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Physical memory");
		this.hbox5.Add (this.label6);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label6]));
		w20.Position = 0;
		w20.Expand = false;
		w20.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.lbVirtualMemory = new global::Gtk.Label ();
		this.lbVirtualMemory.Name = "lbVirtualMemory";
		this.lbVirtualMemory.LabelProp = global::Mono.Unix.Catalog.GetString ("0.0");
		this.hbox5.Add (this.lbVirtualMemory);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.lbVirtualMemory]));
		w21.Position = 1;
		w21.Expand = false;
		w21.Fill = false;
		this.vbox2.Add (this.hbox5);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox5]));
		w22.Position = 1;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Homogeneous = true;
		this.hbox6.Spacing = 6;
		this.hbox6.BorderWidth = ((uint)(3));
		// Container child hbox6.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.Xalign = 0F;
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Priority:");
		this.hbox6.Add (this.label5);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label5]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.lbPriority = new global::Gtk.Label ();
		this.lbPriority.Name = "lbPriority";
		this.lbPriority.LabelProp = global::Mono.Unix.Catalog.GetString ("0.0");
		this.hbox6.Add (this.lbPriority);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.lbPriority]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		this.vbox2.Add (this.hbox6);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox6]));
		w25.Position = 2;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Homogeneous = true;
		this.hbox7.Spacing = 6;
		this.hbox7.BorderWidth = ((uint)(3));
		// Container child hbox7.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Start Processor Time:");
		this.hbox7.Add (this.label7);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label7]));
		w26.Position = 0;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.lbStartProcessorTime = new global::Gtk.Label ();
		this.lbStartProcessorTime.Name = "lbStartProcessorTime";
		this.lbStartProcessorTime.LabelProp = global::Mono.Unix.Catalog.GetString ("0");
		this.hbox7.Add (this.lbStartProcessorTime);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.lbStartProcessorTime]));
		w27.Position = 1;
		w27.Expand = false;
		w27.Fill = false;
		this.vbox2.Add (this.hbox7);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox7]));
		w28.Position = 3;
		w28.Expand = false;
		w28.Fill = false;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w29.Position = 3;
		w29.Expand = false;
		w29.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.lbOk = new global::Gtk.Label ();
		this.lbOk.Name = "lbOk";
		this.hbox3.Add (this.lbOk);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.lbOk]));
		w30.Position = 0;
		w30.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.lbError = new global::Gtk.Label ();
		this.lbError.Name = "lbError";
		this.hbox3.Add (this.lbError);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.lbError]));
		w31.Position = 1;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w32.Position = 4;
		w32.Expand = false;
		w32.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 404;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnOK.Clicked += new global::System.EventHandler (this.OnBtnOKClicked);
		this.btnInfo.Clicked += new global::System.EventHandler (this.OnBtnInfoClicked);
	}
}
