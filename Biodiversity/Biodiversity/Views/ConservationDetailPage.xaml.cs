using System;
using Biodiversity.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConservationDetailPage : ContentPage
    {
        public ConservationDetailPage(Conservation conservationItem)
        {
            InitializeComponent();
            BindingContext = conservationItem;
            conservationInstance = conservationItem;
        }
        public Conservation conservationInstance;
        void OnUrlClicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri(conservationInstance.Url));
        }
    }
}