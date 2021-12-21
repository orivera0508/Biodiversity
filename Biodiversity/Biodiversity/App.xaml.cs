using Biodiversity.Views;
using Xamarin.Forms;
using Biodiversity.Models;
using System.IO;
using System;
namespace Biodiversity
{
    public partial class App : Application
    {
        static Database Database;

        // Create the database connection as a singleton.
        public static Database database
        {
            get
            {
                if (Database == null)
                {
                    Database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return Database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new HomePage());
        }

        // Create the database connection as a singleton.

        public App(string databaseLocation)
        {
            InitializeComponent();
            MainPage = new AppShell();
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
