using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Views
{
     public class Question
    {
        private int id;
        private string Quest;
        private string resp1;
        private string resp2;
        private string resp3;
        private string resp4;
        private string correcto;

        public int Id { get { return id; } set { id = value; } }
        public string quest_ { get { return Quest; } set { Quest = value; } }
        public string resp1_{ get { return resp1; } set { resp1 = value; } }
        public string resp2_ { get { return resp2; } set { resp2 = value; } }
        public string resp3_ { get { return resp3; } set { resp3 = value; } }
        public string resp4_ { get { return resp4; } set { resp4 = value; } }
        public string correct { get { return correcto; } set { correcto = value; } }

        public Question() { }

        public Question setupQuestion(Question quest) { return quest; }
    }
}
