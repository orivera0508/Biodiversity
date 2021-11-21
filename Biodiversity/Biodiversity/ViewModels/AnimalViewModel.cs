using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Biodiversity.Models;
using Biodiversity.Services;
using MvvmHelpers;
using Xamarin.Forms;


namespace Biodiversity.ViewModels
{
    class AnimalViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        //public string Trivia { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }

        private DBFirebase services;

        public Command AddAnimalCommand { get; }

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

        public AnimalViewModel()
        {
            services = new DBFirebase();
            Animals = services.getAnimal();
            AddAnimalCommand = new Command(async () => await addAnimalAsync(Id, Name, Lat, Lng, Type, Desc, ImageName, ImagePath));
        }

        public async Task addAnimalAsync(int Id, string Name, float Lat, float Lng, string Type, string Desc, string ImageName, string ImagePath)
        {
            await services.AddAnimal(Id, Name, Lat, Lng, Type, Desc, ImageName, ImagePath);
        }
    }
}
