using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Forms_5.Models
{
    public class Category
    {
        //public string ID { get; } = Guid.NewGuid().ToString();
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; } = " ";
    }
}
