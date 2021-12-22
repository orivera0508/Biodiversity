using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SQLite;
using System.Threading.Tasks;
namespace Biodiversity.Models
{
    public class Database
    {
       readonly SQLiteAsyncConnection database;

        public Database(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.DropTableAsync<Animal>().Wait();
            database.DropTableAsync<Plant>().Wait();
            database.DropTableAsync<Conservation>().Wait();
            database.CreateTableAsync<Animal>().Wait();
            database.CreateTableAsync<Plant>().Wait();
            database.CreateTableAsync<Conservation>().Wait();
            SavePlantAsync();
            SaveConservationAsync();
            SaveAnimalAsync();
        }

       public Task<List<Animal>> GetAnimalAsync()
       {
          return database.Table<Animal>().ToListAsync();
       }

        public Task<int> SaveAnimalAsync()
        {
           return database.InsertAllAsync(animalList);
        }

        public Task<List<Plant>> GetPlantAsync()
        {
            return database.Table<Plant>().ToListAsync();
        }

        public Task<int> SavePlantAsync()
        {
            return database.InsertAllAsync(plantList);
        }

        public Task<List<Conservation>> GetConservationAsync()
        {
            return database.Table<Conservation>().ToListAsync();
        }

        public Task<int> SaveConservationAsync()
        {
            return database.InsertAllAsync(conservationList);
        }

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
    }
}

//SELECT ImagePath FROM animals WHERE isNew = True JOIN plants ON isNew = TRUE
