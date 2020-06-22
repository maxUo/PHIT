using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PHIT.ViewModels;

namespace PHIT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreen : ContentPage
    {
        public LoginScreen()
        { 
            var vm = new LoginModel();

            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login/Password Entered", "Try Again");
            InitializeComponent();

            Username.Completed += (object sender, EventArgs e) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs e) =>
            {
                vm.LoginCommand.Execute(null);
            };
        }
    }
}