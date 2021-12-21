using Biodiversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using SQLite;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalPage : ContentPage
    {
        public ObservableCollection<Animal> ListCon { get; } = new ObservableCollection<Animal>(App.database.GetAnimalAsync().Result);
        public AnimalPage()
        {
            InitializeComponent();
        }

        public List<Animal> animalList;
        void OnPlantClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Shell.Current.GoToAsync($"//{nameof(PlantPage)}");
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            animalListView.ItemsSource = ListCon;
            animalList = await App.database.GetAnimalAsync();
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

            Animal tappedPost = (Animal)((ListView)sender).SelectedItem;
            Navigation.PushAsync(new AnimalDetailPage(tappedPost));
        }

        private void mySearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchResult = animalList.Where(c => c.Name.ToLower().Contains(mySearchBar.Text.ToLower()));
            animalListView.ItemsSource = searchResult;
        }
    }
}