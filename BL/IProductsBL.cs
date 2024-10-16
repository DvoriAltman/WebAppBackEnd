using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IProductsBL
    {
        Task<List<Product>> GetAllProducts();
    }
}
