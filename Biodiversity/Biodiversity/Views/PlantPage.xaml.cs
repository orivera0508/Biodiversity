using Biodiversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantPage : ContentPage
    {
        public PlantPage()
        {
            InitializeComponent();
        }

        public List<Plant> plantList;
        void OnAnimalClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Shell.Current.GoToAsync($"//{nameof(AnimalPage)}"); 
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            plantListView.ItemsSource = await App.database.GetPlantAsync();
            plantList = await App.database.GetPlantAsync();
        }
        void OnSearchClicked(object sender, EventArgs e)
        {
            if (mySearchBar.IsVisible == false)
            {
                mySearchBar.IsVisible = true;
            }
            else
            {
                mySearchBar.IsVisible = false;
            }
        }
        void ItemTapped(object sender, ItemTappedEventArgs e)
        {

            Plant tappedPost = (Plant)((ListView)sender).SelectedItem;
            Navigation.PushAsync(new PlantDetailPage(tappedPost));
        }

        private void mySearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchResult = plantList.Where(c => c.Name.ToLower().Contains(mySearchBar.Text.ToLower()));
            plantListView.ItemsSource = searchResult;
        }
    }
}