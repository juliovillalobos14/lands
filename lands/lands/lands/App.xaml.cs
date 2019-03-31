using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace lands
{
    //Colocar siempre los using dentro de namespaces
    using Views;
    public partial class App : Application
	{
        #region Constructors
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }
        #endregion

        #region Metods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
