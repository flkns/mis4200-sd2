using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mis4200_sd2.Models
{
    // [Bind(Exclude = "labelID")]
    public class Label
    {
        [Key]
        public int labelID { get; set; }

        [StringLength(50)]
        public string labelName { get; set; }

        [DataType(DataType.Date)]
        public DateTime foundedDate { get; set; }

    }
}