using System;
using Biodiversity.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
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