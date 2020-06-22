using Xamarin.Forms;
using PHIT.Views;

namespace PHIT
{
    public partial class App : Application
    {

        public App()
        {
            MainPage = new LoginScreen();
        }
    }
}
