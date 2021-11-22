using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Views
{
    public abstract class PreguntasBuilder
    {
       protected Preguntas QuestionQuiz;
       public Preguntas gettingQuestion() { return QuestionQuiz; }

       public void CreandoInstancia() { QuestionQuiz = new Preguntas(); }

        public abstract void Building(Preguntas pregunta);

    }
}
