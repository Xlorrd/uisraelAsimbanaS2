using Microsoft.Maui.Animations;

namespace asimbanaS2.Vistas;

public partial class vistaLogin : ContentPage
{
	public vistaLogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
		string usuario = "alex";
		string contrasena = "qwerty";

		if (txtUsuario.Text==usuario && txtContrasena.Text==contrasena)
		{
			Navigation.PushAsync(new calificaciones(usuario));
		}
		else
		{
			DisplayAlert("Fallo","Usuario u contraseña incorrecto","Cancelar");
		}
		
		

    }
}