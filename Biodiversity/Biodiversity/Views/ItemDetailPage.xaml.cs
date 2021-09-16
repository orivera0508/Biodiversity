using Biodiversity.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Biodiversity.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}