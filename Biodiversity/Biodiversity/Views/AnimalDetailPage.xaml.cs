using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biodiversity.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalDetailPage : ContentPage
    {
        public AnimalDetailPage(Animal animalItem)
        {
            InitializeComponent();
            BindingContext = animalItem;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}