using System;
using Xamarin.Forms;
using System.Linq;
using Biodiversity.Models;

namespace Biodiversity.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            var AnimalLstItems = AnimalPage.animalList.Skip(Math.Max(0, AnimalPage.animalList.Count() - 2)).Take(3).ToList();
            var PlantLstItems = PlantPage.plantList.Skip(Math.Max(0, PlantPage.plantList.Count() - 2)).Take(3).ToList();

            var combination = AnimalLstItems.Concat(PlantLstItems);

            itemListView.ItemsSource = combination;
        }


        void OnAnimalClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Shell.Current.GoToAsync($"//{nameof(AnimalPage)}");
        }

        void OnPlantClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Shell.Current.GoToAsync($"//{nameof(PlantPage)}");
        }

        void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Item tappedPost = (Item)((ListView)sender).SelectedItem;
            Navigation.PushAsync(new PlantDetailPage(tappedPost));
        }
    }
}