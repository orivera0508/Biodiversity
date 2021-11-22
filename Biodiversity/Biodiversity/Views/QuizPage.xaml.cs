using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Biodiversity.Views
{
    public partial class QuizPage : ContentPage
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        public static List<Preguntas> listapreguntas = new List<Preguntas>
        {
            new Preguntas
            {
                Id = 1,
                Quest_ = "1. En matemáticas, son un conjunto de puntos en el espacio.",
                resp1_ = "Figuras Geométricas",
                resp2_ = "Partes Homólogas",
                resp3_ = "Axiomas",
                resp4_ = "Lugares Geométricos",
                Correcto = "Figuras Geométricas",
            },
            new Preguntas
            {
                Id = 2,
                Quest_ = "2. Es una declaración, que se considera verdad per sé, y que " +
                "por ser una verdad básica no puede ser probada o demostrada porque simplemente se considera evidente.",
                resp1_ = "Representación Gráfica",
                resp2_ = "Axioma",
                resp3_ = "Puntos",
                resp4_ = "Línea Recta",
                Correcto = "Axioma",
            },
            new Preguntas
            {
                Id = 3,
                Quest_ = "3. Se refiere a dos figuras que coinciden en todas sus partes, esto es, cuando son iguales. (Tienen la misma forma y el mismo tamaño).",
                resp1_ = "Teoremas",
                resp2_ = "Geometría Plana",
                resp3_ = "Figuras Congruentes",
                resp4_ = "Figuras Paralelas",
                Correcto = "Figuras Congruentes"
            },
            new Preguntas
            {
                Id = 4,
                Quest_ = "4. Son un conjunto de puntos que satisfacen ciertas condiciones, en otras palabras, un conjunto de puntos que tienen al menos una propiedad en común.",
                resp1_ = "Representaciones gráficas",
                resp2_ = "Planos",
                resp3_ = "Postulados",
                resp4_ = "Lugares Geométricos",
                Correcto = "Lugares Geométricos"

            }
        };
        int point = 1, score = 0;
        string RespuestaCorrecta;

        protected void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private string SetPregunta(int ID)
        {
            Preguntas list = listapreguntas.Where(a => a.Id == ID).SingleOrDefault();
            try
            {
                lblpreguntita.Text = list.Quest_;
                btnresp1.Text = list.resp1_;
                btnresp2.Text = list.resp2_;
                btnresp3.Text = list.resp3_;
                btnresp4.Text = list.resp4_;
                RespuestaCorrecta = list.Correcto;
            }
            catch (Exception)
            {

            }
            
            return RespuestaCorrecta;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (btnresp1.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (btnresp2.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (btnresp3.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }
      
        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (btnresp4.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            btnPuntuacion.IsVisible = true;

        }
        async void MostrarAlerta(object sender, EventArgs e)
        {
            await DisplayAlert("Puntuación", "Su Puntuación final es de: " + score + " / 4 puntos.", "OK");
        }
    }
}
