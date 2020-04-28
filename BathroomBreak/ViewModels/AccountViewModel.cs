using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BathroomBreak.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {
        private string _name;
        private string _email;
        private string _password;
        private string _confirmPassword;
        private bool _isAcceptedTermsAndConditions;

        public string Name { get => _name; set {
                _name = value;
                RaisePropertyChanged(nameof(Name)); } }
        public string Email { get => _email; set { _email = value; RaisePropertyChanged(nameof(Email)); } }
        public string Password { get => _password; set { _password = value; RaisePropertyChanged(nameof(Password)); } }
        public string ConfirmPassword { get => _confirmPassword; set { _confirmPassword = value; RaisePropertyChanged(nameof(ConfirmPassword)); } }
        public bool IsAcceptedTermsAndConditions { get => _isAcceptedTermsAndConditions; set { _isAcceptedTermsAndConditions = value; RaisePropertyChanged(nameof(IsAcceptedTermsAndConditions)); } }

        public Command ClickCommand => new Command<string>((url) => {
            Application.Current.MainPage.DisplayAlert("Terms & Conditions", Configuration.BathroomBreakConstants.TermsAndConditions, "OK");
        });
    }
}
