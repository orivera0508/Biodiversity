using System;
using System.Collections.Generic;
using System.Text;

namespace Biodiversity.Models
{
    public class Conservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Link { get; set; }
        public string ImagePath { get; set; }

        public Conservation() { }
    }
}