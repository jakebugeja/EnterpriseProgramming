using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testToDelete2.Models;

namespace testToDelete2.Data.Repositories
{
    public class ProductRepository
    {
        private ApplicationDbContext context;
        public ProductRepository(ApplicationDbContext _context)
        {
            context = _context;
        }

        public void addProduct(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }
        public void RemoveProduct(Product p)
        {
            context.Products.Remove(p);
            context.SaveChanges();
        }
    }
}
