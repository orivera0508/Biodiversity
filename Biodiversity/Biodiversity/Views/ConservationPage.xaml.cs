using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        void OnSearchClicked(object sender, EventArgs e)
        {
            searchButton.IsEnabled = false;
            SearchBar searchBar = new SearchBar { Placeholder = "Search items..." };
            StackLayout.Children.Insert(0, searchBar);
        }
    }
}