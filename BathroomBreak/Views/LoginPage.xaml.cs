using System;
using System.Collections.Generic;
using BathroomBreak.ViewModels;
using Xamarin.Forms;

namespace BathroomBreak.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var loginViewModel = new LoginViewModel();

            BindingContext = loginViewModel;
        }

        async void CreateAccountButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AccountCreationPage());
        }

        public async void SigninButton_Clicked(System.Object sender, System.EventArgs e)
        {
            //await Navigation.PushAsync(new MainPage());
            App.Current.MainPage = new MainPage();
        }
    }
}
