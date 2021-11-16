using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Biodiversity.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Title = "Home";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));

            //PlantsPageCommand = new Command(GoToPlantsPage);
        }

        public ICommand OpenWebCommand { get; }

        public Command PlantsPageCommand { get; }

        public Command AnimalsPageCommand { get; }

        //private async void GoToPlantsPage(object obj)
        //{
            // await Shell.Current.GoToAsync(nameof(PlantPage.xaml));
        //}
    }
}