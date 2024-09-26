namespace GuessWhoGame.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // Login button click handler
        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                // Navigate to HomePage with the username
                await Shell.Current.GoToAsync($"HomePage?username={username}");
            }
            else
            {
                await DisplayAlert("Error", "Please enter a valid username and password.", "OK");
            }
        }

        // Guest button click handler
        private async void OnGuestLoginButtonClicked(object sender, EventArgs e)
        {
            // Navigate to HomePage as a Guest
            await Shell.Current.GoToAsync($"HomePage?username=Guest");
        }
    }
}
