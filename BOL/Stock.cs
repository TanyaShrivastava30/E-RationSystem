using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Stock
    {
        [Key]
        public int Serial_No { get; set; }

        [Required]
        public string Stock_Id { get; set; }
        [Required]
        public int Item_Id { get; set; }
        [Required]
        public string Item_Name { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float Price { get; set; }

        public int Category_Id { get; set; }
    }
}
