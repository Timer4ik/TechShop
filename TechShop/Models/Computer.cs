using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShop.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; } = 0;
        public string Photo { get; set; } = "default.png";
        public DateTime Created { get; set; } = DateTime.Now;   
    }
}
