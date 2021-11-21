using Biodiversity.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Biodiversity.Services
{
    class DBFirebase
    {
        FirebaseClient client;
        private int id;
        private string name;
        private float lat;
        private float lng;
        private string desc;
        private string imageName;
        private string imagePath;

        public DBFirebase()
        {
            client = new FirebaseClient("https://biodiversity-b2d4d-default-rtdb.firebaseio.com/");
        }

        public ObservableCollection<Animal> getAnimal()
        {
            var animalData = client
                .Child("Animals")
                .AsObservable<Animal>()
                .AsObservableCollection();
            
            return animalData;
        }

        public async Task AddAnimal(int Id, string Name, float Lat, float Lng, string Type, string Desc, string ImageName, string ImagePath)
        {
            Animal a = new Animal() { Id = id, Name = name, Lat = lat, Lng = lng, Type = Type, Desc = desc, ImageName = imageName, ImagePath = imagePath };
            await client
                .Child("Animals")
                .PostAsync(a);
        }
    }
}
