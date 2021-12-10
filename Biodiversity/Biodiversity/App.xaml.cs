using Biodiversity.Views;
using Xamarin.Forms;

namespace Biodiversity
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new HomePage());
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
            MainPage = new AppShell();
            DatabaseLocation = databaseLocation;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
