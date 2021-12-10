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

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ConservationPage : ContentPage
    {
        public static List<Conservation> conservationList = new List<Conservation>
        {
            new Conservation
            {
                Id = 1,
                Desc = "The Manatee Conservation Center, directed by the Caribbean Stranding Network and the Inter-American University of Puerto Rico, is dedicated to the conservation of endangered manatees through stranding rescue and response programs, rehabilitation and veterinary care, research Population and Community Outreach in Puerto Rico and the Caribbean.",
                Name = "Manati Conservation Center",
                Url = "https://manatipr.org/",
                ImagePath = "https://www.discoverpuertorico.com/sites/default/files/listing_images/profile/11882/manati0-2e6279395056a36_2e627a9d-5056-a36a-08061d52d56883c2.jpg"

            },

            new Conservation
            {
                Id = 2,
                Desc = "The Chelonia Association is an international non-profit organization whose purposes are directed to the carrying out of scientific studies and the conservation of threatened species and ecosystems , as well as the execution of international cooperation projects , to contribute to a more sustainable human development in collaboration with local communities, the preservation of biodiversity and ecosystem services , the slowdown of climate change and the circular economy.",
                Name = "Chelonia",
                Url = "https://www.asociacionchelonia.org/",
                ImagePath = "https://static.wixstatic.com/media/70bbc4_270e212ab5ae4ca6b3d9e016a3456162.png/v1/fill/w_144,h_91,al_c,q_85,usm_0.66_1.00_0.01/70bbc4_270e212ab5ae4ca6b3d9e016a3456162.webp"
            },

            new Conservation
            {
               Id = 3,
               Desc = "Official page of the Department of Natural and Environmental Resources (DNER) Protecting, conserving and managing the natural and environmental resources of our Island Puerto Rico and all the keys, islands and islets that surround it",
               Name = "DRNA",
               Url = "https://www.drna.pr.gov/",
               ImagePath = "https://www.drna.pr.gov/wp-content/uploads/2018/11/cropped-drna_logo.png"
            },

            new Conservation
            {
               Id = 4,
               Desc = "Para la Naturaleza brings together every person who wants a sustainable future for Puerto Rico, where our children can grow up in habitable cities, swim in the crystal-clear waters of our rivers and feed themselves off the land.",
               Name = "Para La Naturaleza",
               Url = "https://www.paralanaturaleza.org/en/",
               ImagePath = "https://brooklynfriends.org/wp-content/uploads/2018/08/para-la-naturaleza-200x143.png"
            },

            new Conservation
            {
               Id = 5,
               Desc = "Conservación ConCiencia is a non-profit organization in Puerto Rico dedicated to environmental research and conservation that aims to promote sustainable development by working collaboratively with communities, governments, academia and the private sector. Conservación ConCiencia is born of the need to address environmental issues in a multifaceted manner utilizing an interdisciplinary toolbox that integrates life sciences, societal welfare and economic security into a problem solving approach.",
               Name = "ConCiencia Conservation",
               Url = "https://oceanfdn.org/projects/conservacion-conciencia/",
               ImagePath = "https://oceanfdn.org/wp-content/uploads/2016/11/ConservacionConCiencia-500x507.png"
            }
        };

        public ObservableCollection<Conservation> ListCon { get; } = new ObservableCollection<Conservation>(conservationList);
        public ConservationPage()
        {
            InitializeComponent();
            conservationListView.ItemsSource = ListCon;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        

        void OnSearchClicked(object sender, EventArgs e)
        {
            if (mySearchBar.IsVisible == false)
            {
                mySearchBar.IsVisible = true;
            }
            else
            {
                mySearchBar.IsVisible = false;
            }
        }

        void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Conservation tappedPost = (Conservation)((ListView)sender).SelectedItem;
            Navigation.PushAsync(new ConservationDetailPage(tappedPost));
        }

        private void mySearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchResult = conservationList.Where(c => c.Name.ToLower().Contains(mySearchBar.Text.ToLower()));
            conservationListView.ItemsSource = searchResult;
        }
    }
}