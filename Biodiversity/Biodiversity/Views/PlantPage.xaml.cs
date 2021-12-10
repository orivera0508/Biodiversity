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
    public partial class PlantPage : ContentPage
    {
        
        public static List<Plant> plantList = new List<Plant>
        {
            new Plant
            {
                Id = 1,
                Desc = "The Sintenis’ Guava is a small evergreen tree that grows to 30 feet. The trunk is slanted and grooved, larger at the bottom, with gray, scaly and shaggy, slightly peeling bark. Branches are slender and hairless, light green color when young, becoming grayish with time. The fruit it produces has a hard skin and contains several small seeds. Fruits and fragrant flower buds are collected from spring to autumn.",
                Name = "Sintenis’ Guava",
                ImagePath = "https://cdn.shopify.com/s/files/1/0047/9730/0847/products/nurserylive-plants-guava-tree-amrud-psidium-guajava-sardar-l49-grown-through-seeds-plant-16968910831756_600x600.jpg?v=1634220909",
                Lat = 18.310320,
                Lng = -65.804899
            },

            new Plant
            {
                Id = 2,
                Desc = "Sintenis’ Holly is a shrub or small tree. Alternating elliptically shaped leaves that are notched at the tip with the edges turned under. The bark is gray, smooth, and typically covered with mosses and liverworts. The flowers are white and the reddish-brown fruits are green when immature. This vegetation is often exposed to winds and typically shrouded with clouds. The extreme rarity of the species makes it vulnerable to natural catastrophes such as hurricanes.",
                Name = "Sintenis Holly",
                ImagePath = "https://cff2.earth.com/uploads/2017/01/03144805/Ilex-cookii-750x400.jpg",
                Lat = 18.310223,
                Lng = -65.804769
            },

            new Plant
            {
               Id = 3,
               Desc = "Palo de Jazmín is an evergreen tree only known from one individual growing in the Palo Colorado forest of the Luquillo Mountains. The tree can grow up to 66ft in height. The leaves are alternate, lack stipules, and have entire margins that are slightly turned under. The inflorescence is a three to six flowered raceme, each flower being borne on curved pedicel. Palo de Jazmín has suffered from the destruction of most of its natural-forest habitat through agricultural, forestry, and human activity. The plant is so rare that at one point it was thought to be extinct until “re-discovered” in 1982.",
               Name = "Jazmin Tree",
               ImagePath = "https://www.flores.ninja/wp-content/uploads/2016/08/El-jazm%C3%ADn.jpg",
               Lat = 18.310321,
               Lng = -65.804569
            },

            new Plant
            {
               Id = 4,
               Desc = "The original extent of the species on the island is unknown, but it was probably common only in the moist limestone region. Because of deforestation and disturbance, the species has become common throughout the moist and wet areas of Puerto Rico. The Maga flower is the “national” flower of the commonwealth of Puerto Rico.  This plant is small to medium size with dark green foliage and large, dark pink or red flowers. In natural forests, the boles of this tree are generally straight, round, and free of limbs.",
               Name = "Maga Tree",
               ImagePath = "https://pics.davesgarden.com/pics/2009/04/07/alexgr1/19c26d.jpg",
               Lat = 18.310123,
               Lng = -65.804456
            },

            new Plant
            {
               Id = 5,
               Desc = "Roytonea borinquena is a rapidly growing tree that reaches an average height of 40 to 85 feet. Young trees can average a 3-foot growth annually. The tree has a smooth, gray trunk with a swollen base and gracefully dropping fronds. The upper trunk is encased in a green column of leaf sheaths. The leaves, arranged on both sides, have short leafstalks with a sheath and blade. The flower is an important nectar source for honey bees, and, like those are vital resources for the highly endangered Puerto Rican Parrot. Seeds are commonly dispersed by birds and rodents. The leaves were used as a roof thatch and dry leaf sheaths (yaguas) were spread out flat to fashion sides for rustic building.",
               Name = "Puerto Rico Royal Palm",
               ImagePath = "https://www.palmpedia.net/wiki/images/thumb/0/07/Post-231-0-89472200-1417703534.jpg/390px-Post-231-0-89472200-1417703534.jpg",
               Lat = 18.310676,
               Lng = -65.804898
            },

            new Plant
            {
               Id = 6,
               Desc = "The Rain Lily is a small plant, with white occasionally pinkish-tinged, six-petal flowers. They bloom from July through October. Glossy, dark green, linear leaves, typically absent when the plant is flowering. The whitish-green perigone enclosing the outer parts of the flower. ",
               Name = "Puerto Rico Zephyr Lily",
               ImagePath = "https://photoplusbyritasim.files.wordpress.com/2012/05/dsc09225-400copy.jpg",
               Lat = 18.310443,
               Lng = -65.804332
            },

            new Plant
            {
               Id = 7,
               Desc = "The Palo Bronco is an evergreen shrub with blunt-pointed leaves. Upper leaf surfaces are green and lower surfaces are a paler green with many yellowish, needle-like hairs. Flowers with white/pink petals and thin-fleshed fruit with large stone; flowers and fruits intermittently throughout the year. Contact with needle-like, stringing hairs on the lower surface or leaves of this plant can cause severe skin irritation and mild skin rash (Dermatitis). Do not eat the leaves on this plant.",
               Name = "Palo Bronco",
               ImagePath = "https://1.bp.blogspot.com/-5VmkqDukRnU/U7K17yCieEI/AAAAAAAATm4/PjA9QoYysAY/s1600/MALPIGHIA+FUCATA+A.jpg",
               Lat = 18.310111,
               Lng = -65.804556
            },

            new Plant
            {
               Id = 8,
               Desc = "Carrasco is an evergreen, poisonous, under-story shrub or tree that can be easily recognized by its slender, un-branched trunk with large, lance-shaped spreading leaves, clusters of tiny, dark-red flowers and small reddish-black fruits. The white sap of the foliage and bark is caustic and can cause skin irritation to some people. When the skin comes into contact with the caustic, poisonous sap from the foliage and bark of this shrub, it can cause a reaction similar to poison ivy in some people. Severe skin irritation and skin rash (Dermatitis). Do not eat the sap of this poisonous shrub.",
               Name = "Carrasco",
               ImagePath = "https://inaturalist-open-data.s3.amazonaws.com/photos/29695250/medium.jpg",
               Lat = 18.310999,
               Lng = -65.804111
            },

            new Plant
            {
               Id = 9,
               Desc = "The tropical plant is a popular ornament which escapes cultivation and is found on shady areas near water or thickest to middle forest elevations or even on the coastal plain. It has a creeping, cane-like stem about 6 feet high, elliptical leaves and yellow floral spike piratically enclosed a light green sheath. The leaves of the Dumbcane plant contain needle-Ike calcium oxalate crystals and proteolytic enzymes. Eating the leaves can cause temporary paralysis of the mouth, tongue, throat and vocal cords. If accidentally rubbed into the eyes the crystals from the leaf can cause temporary vision loss and swelling of the eyelid.",
               Name = "Dumbcane",
               ImagePath = "https://www.ourhouseplants.com/imgs-content/Dieffenbachia-Camilla.jpg",
               Lat = 18.310202,
               Lng = -65.804213
            },

            new Plant
            {
               Id = 10,
               Desc = "Plumerias can grow to be large shrubs or even small trees. In tropical regions, plumeria may reach a height of 30 to 40 inches and 20 inches wide. They have wide spaced thick branches, round or pointed, long leathery, green leaves in clusters near the branch tips. Plumeria produces very fragrant clusters of showy, waxy flowers in various shades of rose and pink. All parts of the plumeria are considered toxic and the sap can cause a rash in sensitive people. The alkaloids in plumeria make the plant extremely bitter and there are no definitive cases of plumeria poisoning. Do not touch or eat flowers or any part of the plant; it may cause skin irritation or mild stomach pain and cramping in some people.",
               Name = "Frangipani",
               ImagePath = "https://essentialoilbulk.com/pub/media/catalog/product/cache/06abfe5b608d6745e7579e4bf119a9f3/f/r/frangipani-absolute-hf-736.jpg",
               Lat = 18.310678,
               Lng = -65.804910
            },
        };

        public ObservableCollection<Plant> ListCon { get; } = new ObservableCollection<Plant>(plantList);
        public PlantPage()
        {
            InitializeComponent();
            plantListView.ItemsSource = ListCon;
        }
        void OnAnimalClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Shell.Current.GoToAsync($"//{nameof(AnimalPage)}"); 
        }
        void OnSearchClicked(object sender, EventArgs e)
        {
            searchButton.IsEnabled = false;
            SearchBar searchBar = new SearchBar { Placeholder = "Search items..." };
            //StackLayout.Children.Insert(0, searchBar);
        }
        void ItemTapped(object sender, ItemTappedEventArgs e)
        {

            Plant tappedPost = (Plant)((ListView)sender).SelectedItem;

            //if (e.Item == null)
            //{
            //    DisplayAlert("Item is null", "Item Null", "Cancel");
            //    return;
            //}
            Navigation.PushAsync(new PlantDetailPage(tappedPost));
        }
    }
}