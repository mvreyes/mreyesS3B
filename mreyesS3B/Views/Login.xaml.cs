namespace mreyesS3B.Views;

public partial class Login : ContentPage
{
    string user = "x";
    string password = "x";
	public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contrasena)
    {
        InitializeComponent();
        user = usuario;
        password = contrasena;
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && password == txtContrasena.Text)
        {
            Navigation.PushAsync(new Views.Home());
        }
        else
        {
            DisplayAlert("ERROR", "Usuario/Contraseña Incorrectos", "Cerrar");
        }
    }

    private void tbnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registro());
    }
}