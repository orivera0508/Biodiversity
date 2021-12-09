using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biodiversity.Models;
using System.Collections.ObjectModel;

namespace Biodiversity.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage(Conservation conservationItem)
        {
            InitializeComponent();
            BindingContext = conservationItem;
        }
    }
}