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
        public IProductsDAL _productDAL; //יצרנו תלות לממשק של הדל כדי לשמור על הכימוס
        public IMapper _mapper; // תלות בממשק איי מאפר כדי להשתמש בדיטיאו
        public ProductsBL(IProductsDAL productDAL, IMapper mapper) //ctor
        {
            _productDAL = productDAL;
            _mapper = mapper;
        }

        public async Task<List<Product>> GetAllProducts()
        { // הפעלת הפונקציה משכבת הדאל עי המשתמש של התלות
            List<Product> products = await _productDAL.GetAllProducts();
            return products;
        }
 

    }
}
