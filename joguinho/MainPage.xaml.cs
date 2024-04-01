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
      			Application.Current.MainPage = new MainPage();
		 }

           private void apertarnoservo(object sender, EventArgs args)
		 {
   			 if (Application.Current != null)
      			Application.Current.MainPage = new MainPage();
		 }
		  private void apertarnaagua(object sender, EventArgs args)
		 {
   			 if (Application.Current != null)
      			Application.Current.MainPage = new MainPage();
		 }
		 private void apertarnocarinho(object sender, EventArgs args)
		 {
   			 if (Application.Current != null)
      			Application.Current.MainPage = new MainPage();
		 }
	 }





