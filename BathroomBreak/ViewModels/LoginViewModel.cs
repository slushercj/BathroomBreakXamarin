using System;
namespace BathroomBreak.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _email;
        private string _password;

        public string Email { get => _email; set { _email = value; RaisePropertyChanged(nameof(Email)); } }
        public string Password { get => _password; set { _password = value; RaisePropertyChanged(nameof(Password)); } }

        public LoginViewModel()
        {
        }
    }
}
