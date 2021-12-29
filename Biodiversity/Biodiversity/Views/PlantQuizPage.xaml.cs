using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Biodiversity.Views
{
    public partial class PlantQuizPage : ContentPage
    {
        public PlantQuizPage()
        {
            InitializeComponent();
        }

        public static List<Question> listapreguntas = new List<Question>
        {
            new Question
            {
                Id = 1,
                quest_ = "1. Which one of these plants is poisonous?",
                resp1_ = "Rain Lily",
                resp2_ = "Frangipani",
                resp3_ = "Sintenis Holly",
                resp4_ = "Maga Tree",
                correct = "Frangipani",
            },

            new Question
            {
                Id = 2,
                quest_ = "2. Which is Puerto Rico’s National flower?",
                resp1_ = "Flor de Maga",
                resp2_ = "Palo de Jazmín",
                resp3_ = "Rain Lily",
                resp4_ = "Frangipani",
                correct = "Flor de Maga",
            },

            new Question
            {
                Id = 3,
                quest_ = "3. Which poisonous plant can be eaten when cooked correctly?",
                resp1_ = "Dumbcane",
                resp2_ = "Elephant Ear",
                resp3_ = "Guinea Grass",
                resp4_ = "Carrasco",
                correct = "Elephant Ear"
            },

            new Question
            {
                Id = 4,
                quest_ = "4. Which one of these is not poisonous?",
                resp1_ = "Dumbcane",
                resp2_ = "Carrasco",
                resp3_ = "Palo Bronco",
                resp4_ = "Palo de Jazmín",
                correct = "Palo de Jazmín"
            },

            new Question
            {
                Id = 5,
                quest_ = "5. What tree’s leaves were used as a roof thatch?",
                resp1_ = "Puerto Rico Royal Palm",
                resp2_ = "Sintenis Guave",
                resp3_ = "Dumbcane",
                resp4_ = "Elephant Ear",
                correct = "Puerto Rico Royal Palm"
            }
        };
        int point = 0, score = 0;
        string correctResponse;

        private string SetQuestion(int ID)
        {
            Question list = listapreguntas.Where(a => a.Id == ID).SingleOrDefault();
            if (point != listapreguntas.Count() + 1)
            {
                lblpreguntita.Text = list.quest_;
                btnresp1.Text = list.resp1_;
                btnresp2.Text = list.resp2_;
                btnresp3.Text = list.resp3_;
                btnresp4.Text = list.resp4_;
                correctResponse = list.correct;

            }
            else
            {
                Navigation.PopAsync();
                DisplayAlert("Game Over!", "Your final score is: " + score + " / " + listapreguntas.Count(), "OK");
            }

            return correctResponse;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (btnresp1.Text == correctResponse)
            {
                score++;
                //btnresp1.BorderColor = Color.FromName("Red");
            }
            point++;
            SetQuestion(point);
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (btnresp2.Text == correctResponse)
            {
                score++;
            }
            point++;
            SetQuestion(point);
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (btnresp3.Text == correctResponse)
            {
                score++;
            }
            point++;
            SetQuestion(point);
        }
      
        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (btnresp4.Text == correctResponse)
            {
                score++;
            }
            point++;
            SetQuestion(point);
        }
    }
}
