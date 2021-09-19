using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mis4200_sd2.Models
{
    // [Bind(Exclude = "artistID")]
    public class Artist
    {
        // [ScaffoldColumn(false)]
        [Key]
        public int artistID { get; set; }

        [StringLength(50)]
        public string artistName { get; set; }

        public ICollection<Album> artistAlbums { get; set; }
    }
}