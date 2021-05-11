using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colman_Final_Web_Project.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float OldPrice { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }
        public string Gender { get; set; }
        public int SupplierId { get; set; }

    }
}
