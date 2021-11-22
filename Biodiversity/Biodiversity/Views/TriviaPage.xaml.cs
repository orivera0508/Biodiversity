using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Navigation.PushAsync(new QuizPage());
        }
    }
}