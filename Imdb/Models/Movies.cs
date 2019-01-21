using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Imdb.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string Name { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime YearOfRelease { get; set; }
        public string Plot  { get; set; }
        public string Image { get; set; }
        //public List<Actor> ActorList { get; set; }
        //public Producer producer { get; set; }
    }

}
