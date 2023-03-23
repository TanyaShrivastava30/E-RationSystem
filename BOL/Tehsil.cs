using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Taluka
    {
        [Key]
        public string Taluka_Id { get; set; }
        
        public string Taluka_Name { get; set;}
        public string District_Id { get; set; }

       
    }
}
