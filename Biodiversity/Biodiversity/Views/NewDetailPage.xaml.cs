using System;
using Biodiversity.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewDetailPage : ContentPage
    {
        public NewDetailPage(New newItem)
        {
            InitializeComponent();
            BindingContext = newItem;
            newInstance = newItem;
        }
        public New newInstance;
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnLocationClicked(object sender, EventArgs e)
        {
            var location = new Location(newInstance.Lat, newInstance.Lng);
            var options = new MapLaunchOptions { Name = newInstance.Name + " Sighting" };
            Xamarin.Essentials.Map.OpenAsync(location,options);
        }
    }
}