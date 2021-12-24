using System;
using Xamarin.Essentials;

namespace Biodiversity
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        void OnEmailClicked(object sender, EventArgs e)
        {
            var address = "samdavid2050@gmail.com";
            var uri = $"mailto:{address}";
            Launcher.OpenAsync(uri);
        }
    }
}
