using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace PHIT.ViewModels
{
    public class LoginModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
            }
        }

        public ICommand LoginCommand { get; set; }

        public LoginModel()
        {
            LoginCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                DisplayInvalidLoginPrompt();
            }
        }
    }
}
