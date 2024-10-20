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
    public class OrdersBL : IOrdersBL
    {
        public IOrdersDAL _ordersDAL; 
        public IMapper _mapper; 
        public OrdersBL(IOrdersDAL ordersDAL, IMapper mapper) //ctor
        {
            _ordersDAL = ordersDAL;
            _mapper = mapper;
        }

        public async Task<List<Order>> GetAllOrders()
        { 
            List<Order> orders = await _ordersDAL.GetAllOrders();
            return orders;
        }
    }
}
