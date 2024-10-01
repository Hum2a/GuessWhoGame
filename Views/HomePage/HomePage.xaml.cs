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

        // Button Click Handlers

        private void OnPlayOnlineClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Play Online button clicked");
            // TODO: Add navigation or functionality for online play
        }

        private void OnLocalMultiplayerClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Local Multiplayer button clicked");
            // TODO: Add navigation or functionality for same-device play
        }

        private void OnPracticeModeClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Practice Mode button clicked");
            // TODO: Add functionality for practice mode against AI
        }

        private void OnHowToPlayClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("How to Play button clicked");
            // TODO: Add tutorial or instructions for how to play the game
        }

        private void OnFriendsClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Friends button clicked");
            // TODO: Add navigation or functionality for friends list
        }

        private void OnLeaderboardClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Leaderboard button clicked");
            // TODO: Add leaderboard functionality
        }

        private void OnMessagesClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Messages button clicked");
            // TODO: Add chat or message center functionality
        }

        private void OnBoardCustomizationClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Board Customization button clicked");
            // TODO: Add board customization functionality
        }

        private void OnAchievementsClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Achievements button clicked");
            // TODO: Add achievements or progress tracking
        }

        private void OnProfileClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Profile button clicked");
            // TODO: Add profile or account management
        }

        private void OnSettingsClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Settings button clicked");
            // TODO: Add settings page or options
        }

        private void OnStoreClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Store button clicked");
            // TODO: Add in-game store or monetization options
        }

        private void OnDailyRewardsClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Daily Rewards button clicked");
            // TODO: Add daily rewards functionality
        }

        private void OnHelpAndSupportClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Help & Support button clicked");
            // TODO: Add help and support options
        }

        private void OnQuitClicked(object sender, EventArgs e)
        {
            _fileLogger.Log("Quit button clicked");
            // TODO: Add quit functionality or prompt
            Application.Current.Quit();
        }
    }
}
