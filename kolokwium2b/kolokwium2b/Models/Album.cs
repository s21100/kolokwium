using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2b.Models
{
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        [Required]
        [MaxLength(20)]
        public string AlbumName { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [ForeignKey("MusicLabel")]
        public int IdMusicLabel { get; set; }
    }
}
