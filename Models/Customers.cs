using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colman_Final_Web_Project.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool HasMembership { get; set; }
    }
}
