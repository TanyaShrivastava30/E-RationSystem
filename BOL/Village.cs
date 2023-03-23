using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Village
    {
        [Key]
        public string Pincode { get; set; }

        [Required]
        public string Village_Name { get; set; }
        public string Taluka_Id { get; set; }
    }
}
