
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	
	private global::Gtk.Entry txtNombre;
	
	private global::Gtk.Button btnSaludar;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Mi Primera Aplicacion");
		this.WindowPosition = ((global::Gtk.WindowPosition)(3));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txtNombre = new global::Gtk.Entry ();
		this.txtNombre.CanFocus = true;
		this.txtNombre.Name = "txtNombre";
		this.txtNombre.IsEditable = true;
		this.txtNombre.InvisibleChar = '●';
		this.fixed1.Add (this.txtNombre);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txtNombre]));
		w1.X = 22;
		w1.Y = 31;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnSaludar = new global::Gtk.Button ();
		this.btnSaludar.CanFocus = true;
		this.btnSaludar.Name = "btnSaludar";
		this.btnSaludar.UseUnderline = true;
		this.btnSaludar.Label = global::Mono.Unix.Catalog.GetString ("Saludar");
		this.fixed1.Add (this.btnSaludar);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnSaludar]));
		w2.X = 214;
		w2.Y = 30;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 348;
		this.DefaultHeight = 117;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnSaludar.Clicked += new global::System.EventHandler (this.OnBtnSaludarClicked);
	}
}
