using DAL.Entities;

namespace BL
{
    public interface IOrdersBL
    {
        Task<List<Order>> GetAllOrders();
    }
}