using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2b.Models.DTO
{
    public class SomeSortOfMusician
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public IEnumerable<SomeSortOfTrack> Tracks { get; set; }
    
    }
}
