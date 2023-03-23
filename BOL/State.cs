using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class State
    {
        [Key]
        public string State_Id { get; set; }
        public string State_Title { get; set; }
    }
}
