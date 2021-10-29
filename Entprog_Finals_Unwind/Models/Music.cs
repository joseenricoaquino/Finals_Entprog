using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entprog_Finals_Unwind.Models
{
    public class Music
    {
        [Key]
        public int MusicId { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string MusicName { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Date Modified")]
        public DateTime? DateModified { get; set; }
    }
}
