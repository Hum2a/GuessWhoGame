using GuessWhoGame.Services;
namespace GuessWhoGame.Views
{
    public partial class HomePage : ContentPage
    {
        private readonly FileLogger _fileLogger;

        public HomePage()
        {
            InitializeComponent();
            _fileLogger = new FileLogger();  // Initialize the file logger
            _fileLogger.Log("HomePage initialized");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _fileLogger.Log("HomePage is appearing");

            try
            {
                WelcomeLabel.Text = "Welcome!";
                _fileLogger.Log("Welcome message set successfully");
            }
            catch (Exception ex)
            {
                _fileLogger.Log($"Error setting welcome message: {ex.Message}");
            }
        }

        private async void OnStartGameClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Start Game button clicked");
            try
            {
                await Shell.Current.GoToAsync("GamePage");
                _fileLogger.Log("Navigated to GamePage");
            }
            catch (Exception ex)
            {
                _fileLogger.Log($"Error navigating to GamePage: {ex.Message}");
            }
        }
    }
}
