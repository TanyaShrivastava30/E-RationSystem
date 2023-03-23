using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Supplier
    {
        [Key]
        public string Supplier_Id { get; set; }
        [Required]
        public string Supplier_Name { get; set; }
        [Required]
        public string Mobile_No { get; set; }
        [Required]
        public string Adhar_No { get; set; }
        [Required]
        public DateOnly Date_Of_Birth { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
