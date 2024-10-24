namespace acentenoRepaso.Views;

public partial class Login : ContentPage
{
	
	public Login()
	{
        InitializeComponent();
	
	}

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		string dato=txtDato.Text;

		Navigation.PushAsync(new Views.Vista1(dato,10));

    }
}