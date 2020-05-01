using EFDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;

namespace EFDemo.Models
{
    public class ProductModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public void CreateProduct()
        {
            var context = Startup.AutofacContainer.Resolve<StoreContext>();
            context.Products.Add(new Product
            {
                Name = this.Name,
                Description = this.Description,
                Price = this.Price,
            });

            var product = context.Products.Where(x => x.Id == 1).FirstOrDefault();
            product.Price = 6000;

            context.Products.Remove(product);

            context.SaveChanges();
            context.Dispose();
        }

        public void CreateCategory()
        {
            var context = Startup.AutofacContainer.Resolve<StoreContext>();
            var product = context.Products.Where(x => x.Id == 1).FirstOrDefault();
            var category = context.Category.Where(x => x.Id == 1).FirstOrDefault();

            product.Categories = new List<ProductCategory>();
            product.Categories.Add(new ProductCategory { Product =  product, Category = category });

            context.SaveChanges();
            context.Dispose();
        }
    }
}
