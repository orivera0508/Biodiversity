using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Views
{
    public class Cuestionario : PreguntasBuilder
    {
        public override void Building(Question p)
        {
            QuestionQuiz.setting_pregunta(p);  
        }
    }
}
