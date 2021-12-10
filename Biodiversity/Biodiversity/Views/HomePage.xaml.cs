using System;
using Xamarin.Forms;

namespace Biodiversity.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
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
    }
}