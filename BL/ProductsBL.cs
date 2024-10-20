using AutoMapper;
using DAL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductsBL : IProductsBL
    {
        public IProductsDAL _productDAL; 
        public IMapper _mapper; 
        public ProductsBL(IProductsDAL productDAL, IMapper mapper) //ctor
        {
            _productDAL = productDAL;
            _mapper = mapper;
        }

        public async Task<List<Product>> GetAllProducts()
        { 
            List<Product> products = await _productDAL.GetAllProducts();
            return products;
        }
 

    }
}
