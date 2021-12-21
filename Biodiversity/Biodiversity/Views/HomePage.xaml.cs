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
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
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
            //Item tappedPost = (Item)((ListView)sender).SelectedItem;
            //Navigation.PushAsync(new PlantDetailPage(tappedPost));
        }
    }
}