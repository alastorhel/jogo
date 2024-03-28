namespace joguinho;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}
     
		private void apertarnaflecha(object sender, EventArgs args)
		 {
   			 if (Application.Current != null)
      			Application.Current.MainPage = new MainPage1();
		 }

	 }





