namespace joguinho;

public partial class MainPage1 : ContentPage
{
	
	public MainPage1()
	{
		InitializeComponent();
	}

    private void apertarnaflechas(object sender, EventArgs args)
		 {
   			 if (Application.Current != null)
      			Application.Current.MainPage = new MainPage2();
		 }

}