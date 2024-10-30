namespace MauiAppLogin;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			List<DadosUsuario> lista_usuarios = new List<DadosUsuario>()
			{
				new DadosUsuario()
				{
					Usuario = "jose",
					Senha = "123"
				},
				new DadosUsuario()
				{
					Usuario = "maria",
					Senha = "321"
				}
			};

			DadosUsuario dados_digitados = new DadosUsuario()
			{
				Usuario = txt_usuario.Text,
				Senha = txt_senha.Text
			};

			// LINQ 
			if(lista_usuarios.Any(
				i => (dados_digitados.Usuario == i.Usuario && 
				dados_digitados.Senha == i.Senha) ))
			{
				SecureStorage.Default.SetAsync("usuario_logado", dados_digitados.Usuario);

				App.Current.MainPage = new Protegida();

			} else
			{
				throw new Exception("Usuário ou senha incorretos.");
			}

		}catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Fechar");
		}
    }
}