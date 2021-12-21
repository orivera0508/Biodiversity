using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biodiversity.Models;
using System.Collections.ObjectModel;

namespace Biodiversity.Views
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ConservationPage : ContentPage
    {
        public ObservableCollection<Conservation> ListCon { get; } = new ObservableCollection<Conservation>(App.database.GetConservationAsync().Result);
        public ConservationPage()
        {
            InitializeComponent();
        }

        public List<Conservation> conservationList;
        void OnPlantClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Shell.Current.GoToAsync($"//{nameof(PlantPage)}");
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            conservationListView.ItemsSource = ListCon;
            conservationList = await App.database.GetConservationAsync();
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

            Conservation tappedPost = (Conservation)((ListView)sender).SelectedItem;
            Navigation.PushAsync(new ConservationDetailPage(tappedPost));
        }

        private void mySearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchResult = conservationList.Where(c => c.Name.ToLower().Contains(mySearchBar.Text.ToLower()));
            conservationListView.ItemsSource = searchResult;
        }
    }

}