using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biodiversity.Models;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConservationPage : ContentPage
    {
        public ConservationPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }
        public static List<Conservation> conservationList = new List<Conservation>
        {
            new Conservation
            {
                Id = 1,
                Desc = "Sample Text",
                Name = "Sample Name",
                Link = "Sample Link",
                ImagePath = "Sample Path"
                
            },

            new Conservation
            {
                Id = 2,
                Desc = "Sample Text",
                Name = "Sample Name",
                Link = "Sample Link",
                ImagePath = "Sample Path"
            },

            new Conservation
            {
               Id = 3,
               Desc = "Sample Text",
               Name = "Sample Name",
               Link = "Sample Link",
               ImagePath = "Sample Path"
            },

            new Conservation
            {
               Id = 4,
               Desc = "Sample Text",
               Name = "Sample Name",
               Link = "Sample Link",
               ImagePath = "Sample Path"
            },

            new Conservation
            {
               Id = 5,
               Desc = "Sample Text",
               Name = "Sample Name",
               Link = "Sample Link",
               ImagePath = "Sample Path"
            }
        };

        
        void OnSearchClicked(object sender, EventArgs e)
        {
            searchButton.IsEnabled = false;
            SearchBar searchBar = new SearchBar { Placeholder = "Search items..." };
            //StackLayout.Children.Insert(0, searchBar);
        }
    }
}