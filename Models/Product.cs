using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Forms_5.Models
{
    public class Product
    {
        //public string ID { get; } = Guid.NewGuid().ToString();
        public string ID { get; set;  } = Guid.NewGuid().ToString();
        public string Name { get; set; } = " ";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string IdCategory { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} : Price: {Price}";
        }
    }
}
