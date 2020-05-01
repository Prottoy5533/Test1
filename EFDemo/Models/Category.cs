using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDemo.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ProductCategory> Categories { get; set; }
    }
}
