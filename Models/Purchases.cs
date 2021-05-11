using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colman_Final_Web_Project.Models
{
    public class Purchases
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public float Price { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }

    }
}
