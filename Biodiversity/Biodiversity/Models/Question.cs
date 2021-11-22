using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Models
{
    class Question
    {
        //questions(questionID:int, questionString:String, correctAnswerID:int)
        public int Id { get; set; }
        public string question { get; set; }

        public int correct_answer_Id { get; set; }

    }
}
