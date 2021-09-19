using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mis4200_sd2.Models
{
    // [Bind(Exclude = "albumID")]
    public class Album
    {
        [Key]
        public int albumID { get; set; }

        [StringLength(50)]
        public string albumName { get; set; }

        [DataType(DataType.Date)]
        public DateTime recordedDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime releasedDate { get; set; }

        [DataType(DataType.Url)]
        public string albumArtURL { get; set; }

        public ICollection<Song> albumSongs { get; set; }

        public virtual Artist artist { get; set; }

        public virtual Label label { get; set; }
    }
}