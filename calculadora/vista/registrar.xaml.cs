using System.Text;

namespace calculadora.vista;

public partial class registrar : ContentPage
{
	public registrar()
	{
		InitializeComponent();
	}

    private void btn_registrar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtNusuario.Text;
		string clave = txtNcontrasena.Text;
		string confir= txtCcontrasena.Text;

        if (clave == confir)
        {
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(clave))
            {
                string usuarioDatos = Preferences.Get("UsuarioDatos", string.Empty);

                StringBuilder sb = new StringBuilder(usuarioDatos);

                if (sb.Length > 0)
                {
                    sb.Append(";");
                }
                sb.Append($"{usuario},{clave}");

                Preferences.Set("UsuarioDatos", sb.ToString());

                DisplayAlert("Registro", "usuario registrado", "ok");
                Navigation.PushAsync(new login());

            }
        }

        else if (usuario == null || clave == null || confir == null)
		{
			DisplayAlert("Alerta", "Ingrese todos los datos", "cerrar");
		}
		else if (clave != confir) {
			DisplayAlert("Alerta", "contraseñas no iguales", "cerrar");
		}



    }
}