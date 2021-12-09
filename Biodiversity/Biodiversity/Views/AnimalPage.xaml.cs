using Biodiversity.ViewModels;
using Biodiversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using Biodiversity.Services;

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
                ImagePath = @"https://cdn.download.ams.birds.cornell.edu/api/v1/asset/253019311/"

            },

            new Animal
            {
                Id = 2,
                Desc = "The Puerto Rican Parrot is a critically endangered endemic species of Puerto Rico, and is the only native parrot in the United States. At one point the parrot was abundant, but through the years, deforestation, predation, diseases and poaching caused the population to crash. Today, the parrot’s population has more than 500 birds that are distributed among state and federal facilities and three wild locations: Maricao Forest, El Yunque National Forest and Rio Abajo Forest.",
                Name = "Puertorican Parrot",
                ImagePath = "https://www.cienciapr.org/sites/cienciapr.org/files/field/image/cotorra_courtesy-omar_monsegur_from_usfws_endangered_species.jpg"
            },

            new Animal
            {
               Id = 3,
               Desc = "The Puerto Rican Screech-Owl is the only small owl found in Puerto Rico measuring only 9 to 10 inches. This owl eats mainly insects and small mammals. This bird is completely nocturnal and is seldom seen during the day. It was one local folklore that eating the freshly cooked heart of this bird would cure asthma. They breed from April to June nesting in hollow trees and cliff crevices. The female lays 2 to 3 white eggs and is fed by her mate while she incubates them. The sound it makes can be heard in the early morning and early evening hours. ",
               Name = "Puerto Rican Screech Owl",
               ImagePath = "https://socialehispanobeata.files.wordpress.com/2013/10/121725752-ezvw5jy3.jpg"
            },

            new Animal
            {
               Id = 4,
               Desc = "The Puerto Rican Tody is a common and widespread endemic to Puerto Rico from the coast to the Mountains. Its habitat are forested areas, including damp forests of hills and mountains, shade coffee plantations and dense thickets in the arid lowlands of the south coast. They are difficult to see from afar because they are diminutive about 11cm in size, but you can hear the sound which is a loud nasal beep or bee-beep.",
               Name = "Puertorican Tody",    
               ImagePath = "https://i.pinimg.com/originals/05/6e/95/056e9563e40ed9ed6105533fa1f5d0cd.jpg"
            },

            new Animal
            {
               Id = 5,
               Desc = "The Small Indian Mongoose was first brought to Puerto Rico from the Malay Peninsula in 1877 in an attempt to control the Black Rat infestation of the sugar cane plantations. The mongoose is a terrestrial animal, they are very agile, and can climb skillfully. They feed on insects, frogs, snakes, birds and other small animals as well as fruits. They shelter in hollow logs or trees, holes in the ground or rock crevices. Mongoose can be found throughout the forest. Mongooses can be infected with rabies please don’t approach them at any time.",
               Name = "Small Indian Mongoose",
               ImagePath = "https://rajajinationalpark.org/wp-content/uploads/small-indian-mongoose.jpg"
            },

            new Animal
            {
               Id = 6,
               Desc = "The Brown Flower Bat is a fruit, flower, pollen and nectar-eating bat that will occasionally eat insects. It is a member of an endemic group of American leaf-nosed bats that has lived in the Caribbean for almost 15 million years. The adult males gather together in a display arena where they use visual, olfactory, and vocal signals to attract females for mating. ",
               Name = "Brown Flower Bat",
               ImagePath = "https://inaturalist-open-data.s3.amazonaws.com/photos/1517119/medium.jpg"
            },

            new Animal
            {
               Id = 7,
               Desc = "The Puerto Rican Boa belongs to the Boidae family, one of the three families of snakes that exists on the island. It can be distinguished from all other native snakes by a unique head shape and disorderly scale arrangement. The Boa typically grows to 6 or 7 feet, although 12-foot-long specimens have been reported. Its color varies from tan to dark brown. These are non-poisonous and feed on rats, mice and bats. They can be seen on the ground or in trees. ",
               Name = "Puerto Rican Boa",
               ImagePath = "https://www.nwf.org/-/media/NEW-WEBSITE/Shared-Folder/Wildlife/Reptiles/reptile_puerto-rican-boa_FWSGOV_600x300.ashx"
            },

            new Animal
            {
               Id = 8,
               Desc = "The Upland is one of the species of rassor ushanoles in Puerto Rico. The lizard can be found around the island and varies in color according to location. The primary body color is black; while in other areas of the island it is yellow. They feed on beetles, spiders, ticks, ants and small snails. A very territorial species, males will vigorously defend their small territories against intruders of the same species. They can be found on ferns, bushes and trunks of small trees.",
               Name = "Upland Grass Anole",
               ImagePath = "https://inaturalist-open-data.s3.amazonaws.com/photos/914/medium.jpg"
            },

            new Animal
            {
               Id = 9,
               Desc = "The Common Coqui is a tiny frog native to the island. The common coqui gets its name from the unique nighttime calling sound (ko-kee) made by the male species. It is the most abundant frog species in Puerto Rico with densities estimated at 20,000 individuals per Hectare. Coqui is considered the unofficial “mascot” of the Island’s people because it is considered a very important symbol of Puerto Rico’s culture. It’s considered a habitat generalist, because it can be found almost anywhere on the island like mesic broad forests, mountains and in urban areas.",
               Name = "Common Coqui",
               ImagePath = "https://welcome.topuertorico.org/img/hp-coqui.jpg"
            },

            new Animal
            {
               Id = 10,
               Desc = "The Mountain Mullet is one of the native fishes that occur in steep mountain streams within the forest. It is locally fished for sport and food. This fresh water fish is an omnivore but prefers mollusks, small shrimps, spiders and other insects, often feeding near the water surface. The fish can be found on the upper reaches of streams and rivers in the island mountains sections.",
               Name = "Mountain Mullet",
               ImagePath = "https://biogeodb.stri.si.edu/sftep/resources/img/images/species/785_5329.jpg"
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
            searchButton.IsEnabled = false;
            SearchBar searchBar = new SearchBar { Placeholder = "Search animals..." };
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