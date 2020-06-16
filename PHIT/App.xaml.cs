using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PHIT.Services;
using PHIT.Views;

namespace PHIT
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginScreen();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
