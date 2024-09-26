using System;
using Microsoft.Maui.Controls;

namespace GuessWhoGame.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                // Navigate to HomePage using Shell's routing
                await Shell.Current.GoToAsync("HomePage");
            }
            else
            {
                await DisplayAlert("Error", "Please enter a valid username and password.", "OK");
            }
        }
    }
}
