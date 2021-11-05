using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Models
{
    class Answer
    {
        //answers(answerID:int, answerString:String, questionID:int foreign key)

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string answer { get; set; }

        public int correct_question_Id { get; set; }
    }
}
