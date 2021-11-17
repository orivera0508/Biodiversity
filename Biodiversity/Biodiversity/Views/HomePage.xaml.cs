using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            Navigation.PushAsync(new PlantPage());
        }

        void OnPlantClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Navigation.PushAsync(new AnimalPage());
        }
    }
}