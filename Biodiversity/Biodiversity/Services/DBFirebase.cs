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

        public DBFirebase()
        {
            client = new FirebaseClient("https://biodiversity-b2d4d-default-rtdb.firebaseio.com/");
        }

        public ObservableCollection<Animal> GetAnimal()
        {
            var animalData = client
                .Child("Animals")
                .AsObservable<Animal>()
                .AsObservableCollection();
            
            return animalData;
        }

        public async Task<ObservableCollection<Animal>> GetAnimalAsync()
        {
            var task = Task.Run(() => GetAnimal());

            return await task;

            //ObservableCollection<Animal> result = await task;

            //return result;
        }

        public async Task AddAnimal(int id, string name, float lat, float lng, string desc, string imageName, string imagePath)
        {
            Animal a = new Animal() { Id = id, Name = name, Lat = lat, Lng = lng, Desc = desc, ImageName = imageName, ImagePath = imagePath };
            await client
                .Child("Animals")
                .PostAsync(a);
        }
    }
}
