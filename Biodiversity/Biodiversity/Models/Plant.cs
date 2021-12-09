using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Lat { get; set; }

        public float Lng { get; set; }

        public string Type { get; set; }

        public string Desc { get; set; }

        //public string Trivia { get; set; }

        public string ImageName { get; set; }

        public string ImagePath { get; set; }
    }
}
