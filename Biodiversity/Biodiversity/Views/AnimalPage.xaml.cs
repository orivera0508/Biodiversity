using Biodiversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalPage : ContentPage
    {

        private ObservableCollection<Animal> _animals = new ObservableCollection<Animal>();
        public ObservableCollection<Animal> Animals
        {
            get { return _animals; }
            set
            {
                _animals = value;
                OnPropertyChanged();
            }
        }


        public static List<Animal> animalList = new List<Animal>
        {
            new Animal
            {
                Id = 1,
                Desc = "The Puerto Rican Emerald is a tiny, iridescent green hummingbird that measures 3.5 to 4 inches (9 to 10 centimeters.) It can be easily identified by its small size, shiny green body, forked tail and smooth un-crested head.",
                Name = "Puerto Rican Emerald",
                ImagePath = @"https://cdn.download.ams.birds.cornell.edu/api/v1/asset/253019311/",
                Lat = 18.310341,
                Lng = -65.804959

            },

            new Animal
            {
                Id = 2,
                Desc = "A tiny, brilliant-green resident of wooded habitats. There are no similar species within its range. Typically perches at low to middle levels in the forest and sallies forth to snag insects from the undersides of leaves. When not actively pursuing a meal, sits rather motionless. Most active, and thus most easily seen, when the sun comes out following rain. Most often first detected by its voice: a loud buzzy “zhip, zhip.”",
                Name = "Puerto Rican Tody",
                ImagePath = "https://cdn.download.ams.birds.cornell.edu/api/v1/asset/289051751/",
                Lat = 18.318515,
                Lng = -65.785433
            },

            new Animal
            {
               Id = 3,
               Desc = "The Puerto Rican coqui (pronounced ko-kee) is a small arboreal frog that’s brown, yellow, or green in color. Its scientific genus name—Eleutherodactylus—means “free toes” because, unlike many frogs, the coqui doesn’t have webbed feet. These amphibians have special disks, or toe pads, on their feet that allow them to climb up vertical structures and cling to trees and leaves. Puerto Rican coquis are one to two inches (2.5 to 5 centimeters) long and weigh two to four ounces (57 to 113 grams). They are one of the largest frog species found in Puerto Rico.",
               Name = "Common Coqui",
               ImagePath = "https://lh6.ggpht.com/G_1QtdNsvnDUPiDu2QEl9nJEPsYched9VaWt_Y0Kr3qDMSZBWCHoVERNxFQwRZofcwImsuKixZy3g6NONSLR=s580",
               Lat = 18.318550,
               Lng = -65.785421
            },

            new Animal
            {
               Id = 4,
               Desc = "Is the only giant Anolis in mainland Puerto Rico, the other giant form A. roosevelti from Culebra Island is now probably extinct. In the most common phase the body, tail, and extremities are emerald green or yellowish green. The head is sometimes suffused with blue and there are some purple scales on the snout and in back of the orbit. The less common phase is gray or greenish gray with dark brown mottles (which may form bars) and dots. In both phases the eye is surrounded by yellow, the dewlap is yellow, and the tongue and palate light orange-yellow.",
               Name = "Giant Anole",
               ImagePath = "https://lh6.ggpht.com/NeaKe8JXoJY2eIm8ZRO15MDVGr2rZkyHDc-yl42azupIYHnGdA0y_6KtDlo5jVpJOYtXaGr_bi04T_nSARw9=s580",
               Lat = 18.318580,
               Lng = -65.785321
            },

            new Animal
            {
               Id = 5,
               Desc = "At seven feet long, Puerto Rican boas—also known as yellow tree boas—are the largest snakes on the island of Puerto Rico. They’re relatively slender reptiles with a dull brown or gray coloration and dark blotches along their bodies. These snakes are not venomous. Instead of using venom to immobilize prey, the boas are constrictors that use their bodies to wrap around prey until it suffocates.",
               Name = "Puerto Rican Boa",
               ImagePath = "https://www.nwf.org/-/media/NEW-WEBSITE/Shared-Folder/Wildlife/Reptiles/reptile_puerto-rican-boa_FWSGOV_600x300.ashx",
               Lat = 18.318500,
               Lng = -65.785314
            },

            new Animal
            {
               Id = 6,
               Desc = "The Puerto Rican crested toad is the only toad species native to Puerto Rico. Named for the bony crests above its large, golden eyes, this toad is also identifiable by an upturned snout and bumpy skin that feels like it’s covered in pebbles. Males are olive green with pads on their thumbs, and females have rougher, dull-brown skin and more prominent crests.",
               Name = "Puerto Rican Crested Toad",
               ImagePath = "https://assets.speakcdn.com//assets/2147/12_pr_crested_toad_-_margarita_woc_colburn.jpg",
               Lat = 18.318420,
               Lng = -65.785321
            },
           
            new Animal
            {
               Id = 7,
               Desc = "Plump brown bird of shady understories in humid evergreen forest of tropical lowlands. Found singly or in pairs, perched quietly at low to middle levels. Often sits still for long periods and is easily overlooked. Note the stout bill, reddish eyes, streaky underparts, bushy white whiskers, and finely dappled whitish to buffy upperparts.",
               Name = "White-whiskered Puffbird",
               ImagePath = "https://cdn.download.ams.birds.cornell.edu/api/v1/asset/165500721/",
               Lat = 18.318215,
               Lng = -65.785376
            },

            new Animal
            {
               Id = 8,
               Desc = "The Upland Gecko is one of the larger-sized gecko species. It typically measures up to 5.7 inches (14.5 centimeters) snout to vent, and has a dark-brown upper body with darker-brown or black spots which are larger on the tail. The underbody is usually orange or reddish-pink with a gray throat that may have dark mottled areas.",
               Name = "Puerto Rico Upland Gecko",
               ImagePath = "https://www.fws.gov/southeast/images/hero/small/monito-gecko-macro.jpg",
               Lat = 18.318762,
               Lng = -65.785680
            },

            new Animal
            {
               Id = 9,
               Desc = "The body of the Tailless whip-scorpion is is flat. It has ten legs, and its first legs are very long, thin and whip-like. This Amblyplygid’s pedipalps (pincer-bearing front arms adapted for sensory and predatory use) are spiny and powerful. Whip-scorpions found in the El Yunque National Forest can be quite large (19 to 25 inches/48 to 63 centimeters, including legs) when compared to those found in other tropical areas, possibly because there are no large mammal predators on the island. Adult females are larger than males.",
               Name = "Tailless Whip-Scorpion",
               ImagePath = "https://alfredocolon.zenfolio.com/img/s/v-10/p1959880747-3.jpg",
               Lat = 18.318445,
               Lng = -65.785571
            },

            new Animal
            {
               Id = 10,
               Desc = "The Mountain Mullet is one of the native fishes that occur in steep mountain streams within the forest. It is locally fished for sport and food. This fresh water fish is an omnivore but prefers mollusks, small shrimps, spiders and other insects, often feeding near the water surface. The fish can be found on the upper reaches of streams and rivers in the island mountains sections.",
               Name = "Mountain Mullet",
               ImagePath = "https://inaturalist-open-data.s3.amazonaws.com/photos/21567120/large.jpg",
               Lat = 18.318412,
               Lng = -65.785456
            },

        };
        ObservableCollection<Animal> listCon = new ObservableCollection<Animal>(animalList);
        public ObservableCollection<Animal> ListCon { get { return listCon; } }
        public AnimalPage()
        {
            InitializeComponent();
            //BindingContext = new AnimalViewModel();
            //Animals = services.GetAnimal();
            animalListView.ItemsSource = listCon;

        }

        void OnPlantClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Shell.Current.GoToAsync($"//{nameof(PlantPage)}");
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

            //searchButton.IsEnabled = false;
            //SearchBar searchBar = new SearchBar { Placeholder = "Search animals..." };
            //searchBar.BindingContext = listCon;
            ////StackLayout.Children.Add(searchBar);
            //StackLayout.Children.Insert(0, searchBar);
            
        }

        void ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
            Animal tappedPost = (Animal)((ListView)sender).SelectedItem;

            //if (e.Item == null)
            //{
            //    DisplayAlert("Item is null", "Item Null", "Cancel");
            //    return;
            //}
            Navigation.PushAsync(new AnimalDetailPage(tappedPost));
        }
    }
}