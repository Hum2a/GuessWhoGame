using Microsoft.Extensions.Logging;

namespace GuessWhoGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Register logging service
            var services = new ServiceCollection();
            services.AddLogging(configure => configure.AddDebug());  // Add debug logger
            var serviceProvider = services.BuildServiceProvider();

            var logger = serviceProvider.GetRequiredService<ILogger<App>>();
            logger.LogInformation("App initialized");

            MainPage = new AppShell();
        }
    }
}
