using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class District
    {
        [Key]
        public string District_Id { get; set; }

        public string District_Name { get; set; }

        public string State_Id { get; set; }
    }
}
