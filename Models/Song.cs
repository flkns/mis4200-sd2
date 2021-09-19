using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mis4200_sd2.Models
{
    // [Bind(Exclude = "songID")]
    public class Song
    {
        // [ScaffoldColumn(false)]
        [Key]
        public int songID { get; set; }

        [StringLength(50)]
        public string songName { get; set; }

        public int songLength { get; set; }

        [StringLength(50)]
        public string songWriter { get; set; }

        [StringLength(50)]
        public string songGenre { get; set; }

        public virtual Album album { get; set; }

        public ICollection<Artist> artists { get; set; }
    }
}