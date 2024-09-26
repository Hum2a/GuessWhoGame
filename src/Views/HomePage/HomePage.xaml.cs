namespace GuessWhoGame.Views
{
    [QueryProperty(nameof(Username), "username")]
    public partial class HomePage : ContentPage
    {
        public string? Username { get; set; }

        public HomePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (!string.IsNullOrEmpty(Username))
            {
                WelcomeLabel.Text = $"Welcome, {Username}!";
            }
            else
            {
                WelcomeLabel.Text = "Welcome!";
            }
        }

        // Add this method to handle the "Start Game" button click
        private async void OnStartGameClicked(object sender, EventArgs e)
        {
            // Navigate to GamePage
            await Shell.Current.GoToAsync("GamePage");
        }
    }
}
