using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BilProjekt.Models
{
    public class CarsCreateVM
    {
        [Display(Name ="Make")]
        [Required(ErrorMessage = "Enter a brand name!")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Enter number of doors")]
        [Range(3,5, ErrorMessage = "Number of doors must be between {1} and {2}")]
        public int Doors { get; set; }
        [Required(ErrorMessage = "Enter the topspeed please")]
        [Range(0, 300, ErrorMessage = "Topspeed must be between {1} to {2}")]

        public int TopSpeed { get; set; }
    }
}
