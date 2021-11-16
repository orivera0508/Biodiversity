using SQLite;
using System;

namespace Biodiversity.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Lat { get; set; }

        public float Lng { get; set; }

        public string Type { get; set; }

        //Description of species
        public string Desc { get; set; }

        //public string Trivia { get; set; }

        public string ImageName { get; set; }

        //Store image path and then display it
        //Just a design idea, waiting for approval... 
        public string ImagePath { get; set; }
    }
}