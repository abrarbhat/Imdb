using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Imdb.Models.ModuleNames;

namespace Imdb.Models
{
    public class Actor
    {
       public Guid Actor_ID { get; set; }
       public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Bio { get; set; }
        public Gender sex{ get; set; }
        //public List<Movies> MoviesList { get; set; }
}
}
