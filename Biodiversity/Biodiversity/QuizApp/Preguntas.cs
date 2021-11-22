using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Views
{
     public class Preguntas
    {
        private int id;
        private string Quest;
        private string resp1;
        private string resp2;
        private string resp3;
        private string resp4;
        private string correcto;

        public int Id { get { return id; } set { id = value; } }
        public string Quest_ { get { return Quest; } set { Quest = value; } }
        public string resp1_{ get { return resp1; } set { resp1 = value; } }
        public string resp2_ { get { return resp2; } set { resp2 = value; } }
        public string resp3_ { get { return resp3; } set { resp3 = value; } }
        public string resp4_ { get { return resp4; } set { resp4 = value; } }
        public string Correcto { get { return correcto; } set { correcto = value; } }

        public Preguntas() { }

        public Preguntas setting_pregunta(Preguntas quest) { return quest; }
    }
}
