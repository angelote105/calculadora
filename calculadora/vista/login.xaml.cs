namespace calculadora.vista;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    String user;
    String password;

   // public login( string usuario, string pass)
    //{
     //   InitializeComponent();
      //  user = usuario;
       // password = pass;
    //}

    private void Inicio_Clicked(object sender, EventArgs e)
    {
        //if (user == txtUsuario.Text && password == txtContraseña.Text)
        //{
        //    Navigation.PushAsync(new vista1(txtUsuario.Text));
        //}

        string usuario = txtUsuario.Text;
        string clave = txtContraseña.Text;

        string userDatos = Preferences.Get("UsuarioDatos", string.Empty);


        if (!string.IsNullOrEmpty(userDatos))
        {

            string[] usuarioArray = userDatos.Split(';');
            bool autenficacion = false;

            foreach( var user in usuarioArray)
            {
                string[] userInfo = user.Split(",");

                if (userInfo.Length==2)
                {
                    string storedUser= userInfo[0];
                    string storeClave= userInfo[1];

                    if (usuario == storedUser && clave==storeClave)
                    {
                        autenficacion=true;
                        break;
                    }
                }
            }

            if (autenficacion) {
                DisplayAlert("Autenticacion", "Inicio de sesion correcta", "ok");
                Navigation.PushAsync(new vista1(txtUsuario.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Error en el usuario", "cerrar");
            }

        }
        else
        {
            DisplayAlert("Alerta", "Nop hay usuario registrados", "cerrar");
        }
    }

    private void Registro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new registrar());
    }
}