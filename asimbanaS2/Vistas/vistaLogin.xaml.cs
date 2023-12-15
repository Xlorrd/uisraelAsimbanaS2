using Android.Text.Method;
using Microsoft.Maui.Animations;
using System.Globalization;

namespace asimbanaS2.Vistas;

public partial class vistaLogin : ContentPage
{
	public vistaLogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
		
		
		
	  string usuario=txtUsuario.Text;
      bool sessionUser= validacion(txtUsuario.Text,txtContrasena.Text);

        if (sessionUser)
        {
            Navigation.PushAsync(new calificaciones(usuario));
        }
        else
        {
            DisplayAlert("Fallo", "Usuario u contraseña incorrecto", "Cancelar");
        }


    }
	private bool validacion(string usuario, string contrasena) {
        string[,] usuarios = new string[,]
        {
            {"asimbana","contraseña" },
            {"ecustodio","qwerty" },
            {"smurillo","ruliman" },
            {"alice", "alicespass"},
            {"bob", "bobspass"},
            {"charlie", "charliespass"},
            {"diana", "dianaspass"},
            {"edgar", "edgarspass"},
            {"fiona", "fionaspass"},
            {"george", "georgespass"},
            {"helen", "helenspass"},
            {"ian", "ianspass"},
            {"julia", "juliaspass"}
        };
        bool Autentification = false;

        for (int i = 0; i < usuarios.GetLength(0); i++)
        {
            
            string usuarioActual = usuarios[i, 0];
            string contrasenaActual = usuarios[i, 1];

            if (usuario == usuarioActual && contrasena == contrasenaActual)
            {
                Autentification = true;
              
                break;
            }

        }
        return Autentification;
	}

}