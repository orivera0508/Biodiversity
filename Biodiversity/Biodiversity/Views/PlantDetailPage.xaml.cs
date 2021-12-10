using System;
using Biodiversity.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantDetailPage : ContentPage
    {
        public PlantDetailPage(Item plantItem)
        {
            InitializeComponent();
            BindingContext = plantItem;
            plantInstance = plantItem;
        }
        public Item plantInstance;

        void OnLocationClicked(object sender, EventArgs e)
        {
            var location = new Location(plantInstance.Lat, plantInstance.Lng);
            var options = new MapLaunchOptions { Name = plantInstance.Name + " Sighting" };
            Xamarin.Essentials.Map.OpenAsync(location, options);
        }
    }
}