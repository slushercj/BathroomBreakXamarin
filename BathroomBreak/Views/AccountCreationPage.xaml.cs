using System;
using System.Collections.Generic;
using BathroomBreak.ViewModels;
using Xamarin.Forms;

namespace BathroomBreak.Views
{
    public partial class AccountCreationPage : ContentPage
    {
        public AccountCreationPage()
        {
            InitializeComponent();
            var accountViewModel = new AccountViewModel();

            BindingContext = accountViewModel;
        }

        void CreateAccountButton_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Create Account", "Creating account", "OK");
        }

        async void BackButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
