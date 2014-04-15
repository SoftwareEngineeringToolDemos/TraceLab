
// This file has been generated by the GUI designer. Do not modify.
namespace TraceLab.UI.GTK
{
	public partial class WelcomePageWidget
	{
		private global::Gtk.EventBox mainEventBox;
		private global::Gtk.VBox mainVbox;
		private global::Gtk.Image coestHeader;
		private global::Gtk.HBox hbox1;
		private global::Gtk.VBox vbox2;
		private global::Gtk.Button buttonCreateNewExperiment;
		private global::Gtk.Button buttonOpenExperiment;
		private global::Gtk.HSeparator hseparator1;
		private global::Gtk.Label labelRecentExperiments;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.NodeView recentExperimentNodeView;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Image image89;
		private global::Gtk.TextView NSFFundingText;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.NodeView onlineResourcesNodeView;
		private global::Gtk.Label labelOnlineResources;
		private global::Gtk.NodeView videoTutorialsTreeView;
		private global::Gtk.Label labelVideoTutorials;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TraceLab.UI.GTK.WelcomePageWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "TraceLab.UI.GTK.WelcomePageWidget";
			// Container child TraceLab.UI.GTK.WelcomePageWidget.Gtk.Container+ContainerChild
			this.mainEventBox = new global::Gtk.EventBox ();
			this.mainEventBox.Name = "mainEventBox";
			// Container child mainEventBox.Gtk.Container+ContainerChild
			this.mainVbox = new global::Gtk.VBox ();
			this.mainVbox.Name = "mainVbox";
			this.mainVbox.Spacing = 6;
			// Container child mainVbox.Gtk.Box+BoxChild
			this.coestHeader = new global::Gtk.Image ();
			this.coestHeader.Name = "coestHeader";
			this.coestHeader.Xalign = 0F;
			this.coestHeader.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("TraceLab.UI.GTK.Resources.Image_StartPageHeader.png");
			this.mainVbox.Add (this.coestHeader);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.mainVbox [this.coestHeader]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child mainVbox.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 12;
			this.hbox1.BorderWidth = ((uint)(6));
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonCreateNewExperiment = new global::Gtk.Button ();
			this.buttonCreateNewExperiment.CanFocus = true;
			this.buttonCreateNewExperiment.Name = "buttonCreateNewExperiment";
			this.buttonCreateNewExperiment.UseUnderline = true;
			this.buttonCreateNewExperiment.Xalign = 0F;
			// Container child buttonCreateNewExperiment.Gtk.Container+ContainerChild
			global::Gtk.Alignment w2 = new global::Gtk.Alignment (0F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w3 = new global::Gtk.HBox ();
			w3.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-new", global::Gtk.IconSize.Menu);
			w3.Add (w4);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w6 = new global::Gtk.Label ();
			w6.LabelProp = global::Mono.Unix.Catalog.GetString ("Create New Experiment...");
			w6.UseUnderline = true;
			w3.Add (w6);
			w2.Add (w3);
			this.buttonCreateNewExperiment.Add (w2);
			this.vbox2.Add (this.buttonCreateNewExperiment);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.buttonCreateNewExperiment]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonOpenExperiment = new global::Gtk.Button ();
			this.buttonOpenExperiment.CanFocus = true;
			this.buttonOpenExperiment.Name = "buttonOpenExperiment";
			this.buttonOpenExperiment.UseUnderline = true;
			this.buttonOpenExperiment.Xalign = 0F;
			// Container child buttonOpenExperiment.Gtk.Container+ContainerChild
			global::Gtk.Alignment w11 = new global::Gtk.Alignment (0F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w12 = new global::Gtk.HBox ();
			w12.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w13 = new global::Gtk.Image ();
			w13.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-open", global::Gtk.IconSize.Menu);
			w12.Add (w13);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w15 = new global::Gtk.Label ();
			w15.LabelProp = global::Mono.Unix.Catalog.GetString ("Open Existing Experiment...");
			w15.UseUnderline = true;
			w12.Add (w15);
			w11.Add (w12);
			this.buttonOpenExperiment.Add (w11);
			this.vbox2.Add (this.buttonOpenExperiment);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.buttonOpenExperiment]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox2.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hseparator1]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelRecentExperiments = new global::Gtk.Label ();
			this.labelRecentExperiments.Name = "labelRecentExperiments";
			this.labelRecentExperiments.Xalign = 0F;
			this.labelRecentExperiments.LabelProp = global::Mono.Unix.Catalog.GetString ("Recent Experiments");
			this.vbox2.Add (this.labelRecentExperiments);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelRecentExperiments]));
			w21.Position = 3;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.recentExperimentNodeView = new global::Gtk.NodeView ();
			this.recentExperimentNodeView.CanFocus = true;
			this.recentExperimentNodeView.Name = "recentExperimentNodeView";
			this.recentExperimentNodeView.EnableSearch = false;
			this.recentExperimentNodeView.HeadersVisible = false;
			this.GtkScrolledWindow.Add (this.recentExperimentNodeView);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w23.Position = 4;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.image89 = new global::Gtk.Image ();
			this.image89.Name = "image89";
			this.image89.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("TraceLab.UI.GTK.Resources.Image_NSFLogo.png");
			this.hbox2.Add (this.image89);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.image89]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.NSFFundingText = new global::Gtk.TextView ();
			this.NSFFundingText.Buffer.Text = "TraceLab is funded under National Science Foundation MRI-R2 Grant # CNS: 0959924." +
				"";
			this.NSFFundingText.CanFocus = true;
			this.NSFFundingText.Name = "NSFFundingText";
			this.NSFFundingText.Editable = false;
			this.NSFFundingText.CursorVisible = false;
			this.NSFFundingText.WrapMode = ((global::Gtk.WrapMode)(2));
			this.hbox2.Add (this.NSFFundingText);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.NSFFundingText]));
			w25.Position = 1;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w26.Position = 5;
			w26.Expand = false;
			w26.Fill = false;
			this.hbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
			w27.Position = 0;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			this.notebook1.ShowBorder = false;
			this.notebook1.BorderWidth = ((uint)(2));
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.onlineResourcesNodeView = new global::Gtk.NodeView ();
			this.onlineResourcesNodeView.CanFocus = true;
			this.onlineResourcesNodeView.Name = "onlineResourcesNodeView";
			this.onlineResourcesNodeView.EnableSearch = false;
			this.onlineResourcesNodeView.HeadersVisible = false;
			this.notebook1.Add (this.onlineResourcesNodeView);
			// Notebook tab
			this.labelOnlineResources = new global::Gtk.Label ();
			this.labelOnlineResources.Name = "labelOnlineResources";
			this.labelOnlineResources.LabelProp = global::Mono.Unix.Catalog.GetString ("Online Resources");
			this.labelOnlineResources.WidthChars = 18;
			this.labelOnlineResources.SingleLineMode = true;
			this.notebook1.SetTabLabel (this.onlineResourcesNodeView, this.labelOnlineResources);
			this.labelOnlineResources.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.videoTutorialsTreeView = new global::Gtk.NodeView ();
			this.videoTutorialsTreeView.CanFocus = true;
			this.videoTutorialsTreeView.Name = "videoTutorialsTreeView";
			this.videoTutorialsTreeView.EnableSearch = false;
			this.videoTutorialsTreeView.HeadersVisible = false;
			this.notebook1.Add (this.videoTutorialsTreeView);
			global::Gtk.Notebook.NotebookChild w29 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.videoTutorialsTreeView]));
			w29.Position = 1;
			// Notebook tab
			this.labelVideoTutorials = new global::Gtk.Label ();
			this.labelVideoTutorials.Name = "labelVideoTutorials";
			this.labelVideoTutorials.LabelProp = global::Mono.Unix.Catalog.GetString ("Video Tutorials");
			this.labelVideoTutorials.WidthChars = 18;
			this.notebook1.SetTabLabel (this.videoTutorialsTreeView, this.labelVideoTutorials);
			this.labelVideoTutorials.ShowAll ();
			this.hbox1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.notebook1]));
			w30.Position = 1;
			this.mainVbox.Add (this.hbox1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.mainVbox [this.hbox1]));
			w31.Position = 1;
			w31.Padding = ((uint)(4));
			this.mainEventBox.Add (this.mainVbox);
			this.Add (this.mainEventBox);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
