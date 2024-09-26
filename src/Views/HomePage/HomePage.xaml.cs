namespace GuessWhoGame.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnStartGameClicked(object sender, EventArgs e)
        {
            // Navigate to the GamePage
            await Shell.Current.GoToAsync("GamePage");
        }
    }
}
