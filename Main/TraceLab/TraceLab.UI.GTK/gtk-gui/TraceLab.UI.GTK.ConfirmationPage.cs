
// This file has been generated by the GUI designer. Do not modify.
namespace TraceLab.UI.GTK
{
	public partial class ConfirmationPage
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.TextView messageTextView;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TraceLab.UI.GTK.ConfirmationPage
			global::Stetic.BinContainer.Attach (this);
			this.Name = "TraceLab.UI.GTK.ConfirmationPage";
			// Container child TraceLab.UI.GTK.ConfirmationPage.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.messageTextView = new global::Gtk.TextView ();
			this.messageTextView.Sensitive = false;
			this.messageTextView.CanFocus = true;
			this.messageTextView.Name = "messageTextView";
			this.messageTextView.Editable = false;
			this.messageTextView.CursorVisible = false;
			this.messageTextView.Justification = ((global::Gtk.Justification)(2));
			this.messageTextView.WrapMode = ((global::Gtk.WrapMode)(2));
			this.messageTextView.LeftMargin = 10;
			this.messageTextView.RightMargin = 10;
			this.vbox2.Add (this.messageTextView);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.messageTextView]));
			w1.Position = 0;
			w1.Padding = ((uint)(25));
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.messageTextView.Hide ();
			this.Hide ();
		}
	}
}
