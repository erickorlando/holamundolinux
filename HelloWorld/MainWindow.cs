using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		txtNombre.Text = Environment.UserName;
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnSaludarClicked (object sender, EventArgs e)
	{
		var msg = new Gtk.MessageDialog (this, 
			DialogFlags.DestroyWithParent, 
			MessageType.Info, 
			ButtonsType.Close, 
			"Hola {0}!, estamos aprendiendo a programar en Linux", 
			txtNombre.Text);
		msg.Show ();

	}
}
