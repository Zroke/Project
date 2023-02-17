using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Model
{
    public class Movie
    {
        public string Name { get; set; }
        public int ProductionYear { get; set; }
        public List<string> ProductionCountries { get; set; }
        public int Duration { get; set; }
        public double Budget { get; set; }
    }
}

