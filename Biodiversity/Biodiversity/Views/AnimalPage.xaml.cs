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


            DBFirebase services = new DBFirebase();


        public static List<Animal> animalList = new List<Animal>
        {
            new Animal
            {
                Id = 1,
                Desc = "Oh Oh Ah Ah",
                Name = "Monke",
                //Link = "Sample Link",
                ImagePath = "https://i.pinimg.com/736x/32/5c/fc/325cfc67933c173e35003b30546a88da.jpg"

            },

            new Animal
            {
                Id = 2,
                Desc = "It's a literal lion.",
                Name = "Lion",
                //Link = "Sample Link",
                ImagePath = "https://cdn.britannica.com/29/150929-050-547070A1/lion-Kenya-Masai-Mara-National-Reserve.jpg"
            },

            new Animal
            {
               Id = 3,
               Desc = "It's a literal Rabbit",
               Name = "Rabbit",
               //Link = "Sample Link",
               ImagePath = "https://www.calacademy.org/sites/default/files/styles/manual_crop_standard_960x540/public/assets/images/Education_Images/TYE_Images/breedingbunnies_blackbunnyattheoaklandzoo_1200x900_credit_ianmacd.jpg?itok=jDEgttlE&c=dda1181bf430fb6c549b7ee29da3be6e"
            },

            new Animal
            {
               Id = 4,
               Desc = "Sample Text",
               Name = "Sample Name",
               //Link = "Sample Link",
               ImagePath = "Sample Path"
            },

            new Animal
            {
               Id = 5,
               Desc = "Sample Text",
               Name = "Sample Name",
               //Link = "Sample Link",
               ImagePath = "Sample Path"
            }
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
    }
}