using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Card_Stock
    {
        [Key]
        public int Serial_No { get; set; }
        [Required]
        public string CardType { get; set; }
        [Required]
        public string Item_Name { get; set; }
        [Required]
        public int Quanity_per_Month { get; set;}
        [Required]
        public float Price_per_Unit { get; set; }
    }
}
