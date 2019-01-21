using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Imdb.Models.ModuleNames;

namespace Imdb.Models
{
    public class Producer
    {
        public Guid Producer_ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public Gender Sex { get; set; }
        public string Bio { get; set; }
      //  public List<Movies> MovieList { get; set; }

    }
}
