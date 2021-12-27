using Biodiversity.Models;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using SQLite;

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
            List<Animal> test = App.database.GetAnimalAsync().Result;
            List<Plant> test2 = App.database.GetPlantAsync().Result;
            test.Reverse();
            test2.Reverse();
            List<New> newList = new List<New>();
            for (int i = 0; i < 2; i++)
            {
                newList.Add(new New()
                {
                    Desc = test[i].Desc,
                    Id = test[i].Id,
                    ImagePath = test[i].ImagePath,
                    Lat = test[i].Lat,
                    Lng = test[i].Lng,
                    Name = test[i].Name
                });

                newList.Add(new New()
                {
                    Desc = test2[i].Desc,
                    Id = test2[i].Id,
                    ImagePath = test2[i].ImagePath,
                    Lat = test2[i].Lat,
                    Lng = test2[i].Lng,
                    Name = test2[i].Name
                });
            }
            itemListView.ItemsSource = new ObservableCollection<New>(newList);
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
            New tappedPost = (New)((ListView)sender).SelectedItem;
            Navigation.PushAsync(new NewDetailPage(tappedPost));
        }
    }
}