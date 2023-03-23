using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace BOL
{
    public class Consumer
    {

        [Key]
        public string Ration_Id { get; set; }

        [Required] 
        public string Name { get; set; }

        [Required]
        public string Mobile_No { get; set; }

        public string Adhar_No { get; set; }

        [Required]
        public string Card_Type { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateOnly Date_of_Birth { get; set; }

        [Required]
        public decimal Income { get; set; }

        [Required]
        public int Total_Members { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Pincode { get; set; }
    }
}
