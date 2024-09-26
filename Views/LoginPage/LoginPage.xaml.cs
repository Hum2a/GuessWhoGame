namespace GuessWhoGame.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // Home button click handler
        private async void OnHomeButtonClicked(object sender, EventArgs e)
        {
            // Navigate to HomePage
            await Shell.Current.GoToAsync("HomePage");
        }
    }
}
