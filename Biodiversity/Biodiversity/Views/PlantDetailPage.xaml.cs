using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biodiversity.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantDetailPage : ContentPage
    {
        public PlantDetailPage(Plant plantItem)
        {
            InitializeComponent();
            BindingContext = plantItem;
            plantInstance = plantItem;
        }
        public Plant plantInstance;

        void OnLocationClicked(object sender, EventArgs e)
        {
            var location = new Location(plantInstance.Lat, plantInstance.Lng);
            var options = new MapLaunchOptions { Name = plantInstance.Name + " Sighting" };
            Xamarin.Essentials.Map.OpenAsync(location, options);
        }
    }
}