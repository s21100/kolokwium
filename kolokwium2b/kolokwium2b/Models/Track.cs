using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2b.Models
{
    public class Track
    {
        [Key]
        public int IdTrack { get; set; }
        [Required]
        [MaxLength(20)]
        public string TrackName { get; set; }
        [Required]
        public float Duration { get; set; }
        [ForeignKey("Album")]
        public int IdMusicAlbum { get; set; }
        public virtual ICollection<Musician_Track> Musician_Tracks { get; set; }
    }
}
