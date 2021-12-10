using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biodiversity.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TriviaPage : ContentPage
    {
        public TriviaPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PlantQuizPage());
        }

        async void OnButton2Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AnimalQuizPage());
        }
    }
}