using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Views
{
    public abstract class PreguntasBuilder
    {
       protected Question QuestionQuiz;
       public Question gettingQuestion() { return QuestionQuiz; }

       public void createInstance() { QuestionQuiz = new Question(); }

       public abstract void Building(Question pregunta);

    }
}
