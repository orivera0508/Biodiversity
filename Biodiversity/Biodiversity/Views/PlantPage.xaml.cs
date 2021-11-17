using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlantPage : ContentPage
    {
        public PlantPage()
        {
            InitializeComponent();
        }
        void OnAnimalClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Navigation.PushAsync(new AnimalPage());
        }
    }
}