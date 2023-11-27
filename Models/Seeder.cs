using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Forms_5.Models
{
    public static class Seeder
    {
        public static List<Category> initCategory()
        {
            List<Category> list = new List<Category>();
            list.Add(new Category() {Name = "Books"});
            list.Add(new Category() { Name = "Drinks" });
            list.Add(new Category() { Name = "Notebooks" });
            list.Add(new Category() { Name = "Smartphones" });
            list.Add(new Category() { Name = "Stationery" });
            return list;
        }
        public static List<Product> initProduct(List<Category> cat)
        {
            List<Product> list = new List<Product>();
            //list.Add(new Product() { Name = "Space Adventure", Price = 778.4m, Category = cat.Where(e => e.Name.Equals("Books")).First() });
            //list.Add(new Product() { Name = "LG2", Price = 1078.4m, Category = cat.Where(e => e.Name.Equals("Smartphones")).First() });
            //list.Add(new Product() { Name = "Scisors", Price = 78.4m, Category = cat.Where(e => e.Name.Equals("Stationery")).First() });
            return list;
        }
    }
}
