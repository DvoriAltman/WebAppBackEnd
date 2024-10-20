using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrdersDAL : IOrdersDAL
    {
        public ShopContext _context;
        public OrdersDAL(ShopContext context)
        {
            _context = context;
        }
     
        public async Task<List<Order>> GetAllOrders()
        {
            List<Order> ordersList = await _context.Orders.ToListAsync(); 
            return ordersList;
        }
    }
}
