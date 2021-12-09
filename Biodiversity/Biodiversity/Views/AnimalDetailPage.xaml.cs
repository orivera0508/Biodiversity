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
    public partial class AnimalDetailPage : ContentPage
    {
        public AnimalDetailPage(Animal animalItem)
        {
            InitializeComponent();
            BindingContext = animalItem;
            animalInstance = animalItem;
        }
        public Animal animalInstance;
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        void OnLocationClicked(object sender, EventArgs e)
        {
            var location = new Location(animalInstance.Lat, animalInstance.Lng);
            var options = new MapLaunchOptions { Name = animalInstance.Name + " Sighting" };
            Xamarin.Essentials.Map.OpenAsync(location,options);
        }
    }
}