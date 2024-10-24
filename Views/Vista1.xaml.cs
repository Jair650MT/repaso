namespace acentenoRepaso.Views;

public partial class Vista1 : ContentPage
{
	string datoU="x";
	public Vista1(string dato,int dato1)
	{
		InitializeComponent();
		datoU=dato;
		lblDato.Text=datoU;
		
	}
}