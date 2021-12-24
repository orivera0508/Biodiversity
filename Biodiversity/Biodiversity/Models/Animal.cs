using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Models
{
    public class Animal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        public string Desc { get; set; }

        public string ImagePath { get; set; }
    }
}