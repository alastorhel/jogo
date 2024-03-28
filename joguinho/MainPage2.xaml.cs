namespace joguinho;

public partial class MainPage2 : ContentPage
{
	
	public MainPage2()
	{
		InitializeComponent();
	}
    private void apertarnaflechar(object sender, EventArgs args)
		 {
   			 if (Application.Current != null)
      			Application.Current.MainPage = new MainPage();
		 }

    }
