using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Government
    {
        [Key]
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        public string Email_Id { get; set; }
        public string Mobile_No { get; set; }
        public string Adhar_No { get; set; }

        public string Designation { get; set; } 

        public DateOnly Date_Of_Birth { get; set; }
        
    }
}
