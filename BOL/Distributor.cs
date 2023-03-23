using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Distributor
    {
        [Key]
        public string Distributor_Id { get; set; }
        [Required]
        public string Distributor_Name { get; set; }
        [Required]
        public string Mobile_No { get; set; }
        [Required]
        public string Adhar_No { get; set; }
        [Required]
        public int Shop_No { get; set; }
        [Required]
        public DateOnly Date_Of_Birth { get; set; }
        [Required]
        public string Password { get; set; } 
       

       
    }
}
