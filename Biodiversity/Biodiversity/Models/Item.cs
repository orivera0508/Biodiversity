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

        //public string Trivia { get; set; }

        public string ImageName { get; set; }

        public byte ImageFile { get; set; }
    }
}