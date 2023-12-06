

namespace asimbanaS2.Vistas;

public partial class mainView : ContentPage
{
	public mainView()
	{
		InitializeComponent();
	}

    private void btnMostrar_Clicked(object sender, EventArgs e)
    {
		string dato = pkPaises.Items[pkPaises.SelectedIndex];

		//DisplayAlert("Elemento Seleccionado",dato.ToString(), "OK");
		lblSeleccion.Text="Elemento seleccionado "+dato;
    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
		string fecha= dpFecha.Date.ToString("dd/MM/yyyy");
		
        lblSeleccion.Text = $"Elemento seleccionado {fecha}";   
    }
}