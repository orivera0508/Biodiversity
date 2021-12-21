using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Biodiversity.Views
{
    public partial class AnimalQuizPage : ContentPage
    {
        public AnimalQuizPage()
        {
            InitializeComponent();
        }

        public static List<Question> listapreguntas = new List<Question>
        {
            new Question
            {
                Id = 1,
                quest_ = "1. Which is a puertorican endangered species?",
                resp1_ = "Pitirre",
                resp2_ = "Bald Eagle",
                resp3_ = "Coqui",
                resp4_ = "Chango",
                correct = "Coqui",
            },

            new Question
            {
                Id = 2,
                quest_ = "2. What months of the year do the Puerto Rican “Mucarito” breed?",
                resp1_ = "August - November",
                resp2_ = "September - January",
                resp3_ = "April - June",
                resp4_ = "March - July",
                correct = "April - June",
            },

            new Question
            {
                Id = 3,
                quest_ = "3. How tall is the “San Pedrito” bird?",
                resp1_ = "about 15cm",
                resp2_ = "1in",
                resp3_ = "about 11cm",
                resp4_ = "4ft",
                correct = "about 11cm"
            },

            new Question
            {
                Id = 4,
                quest_ = "4. When were the Small Indian Mongoose brought to Puerto Rico?",
                resp1_ = "1877",
                resp2_ = "1980",
                resp3_ = "1860",
                resp4_ = "1972",
                correct = "1877"
            },

            new Question
            {
                Id = 5,
                quest_ = "5. What do the Brown Flower Bat eat?",
                resp1_ = "Blood",
                resp2_ = "Meat",
                resp3_ = "Fruits",
                resp4_ = "Other bats",
                correct = "Fruits"
            }
        };
        int point = 0, score = 0;
        string correctResponse;

        private string SetQuestion(int ID)
        {
            Question list = listapreguntas.Where(a => a.Id == ID).SingleOrDefault();
            if (point != listapreguntas.Count()+1)
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
                DisplayAlert("Game Over!", "Your final score is: " + score + " / " + listapreguntas.Count(), "OK");
                Navigation.PopAsync();
            }
            
            return correctResponse;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (btnresp1.Text == correctResponse)
            {
                score++;
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
