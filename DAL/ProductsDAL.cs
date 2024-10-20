using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductsDAL : IProductsDAL
    {
        public ShopContext _context;
        public ProductsDAL(ShopContext context)
        {
            _context = context;
        }
       
        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> productsList = await _context.Products.ToListAsync(); 
            return productsList;
        }
    }
}
