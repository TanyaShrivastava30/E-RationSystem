using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Login
    {
        [Key]
        public string User_Name { get; set; }
        [Required]
        public string Password { get; set; }

        public int Role_Id { get; set; }
       
    }
}
