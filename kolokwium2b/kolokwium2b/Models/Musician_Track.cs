using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2b.Models
{
    public class Musician_Track
    {
        [ForeignKey("Track")]
        public int IdTrack { get; set; }
        [ForeignKey("Musician")]
        public int IdMusician { get; set; }
        public virtual Musician Musician { get; set; }
        public virtual Track Track { get; set; }
    }
}
