using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgMovieLac
{
    class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public double imbd { get; set; }

        public Movie(int id, string name, int year, double imbd)
        {
            this.id = id;
            this.name = name;
            this.year = year;
            this.imbd = imbd;
        }


        public override string ToString()
        {
            return this.id + ": " + this.name + "(" + this.year + ") - Rating: " + this.imbd;
        }
    }
}
