using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApotekMedicalCenter.Models
{
    public class AkunModel
    {
        [Key]
        [Required]
        public int IdAkun { get; set; }
        
        [Required]
        public string Username { set; get; }

        [Required]
        public string Password { get; set; }

        [Required]
        public int HakAkses { set; get; }
    }
}
