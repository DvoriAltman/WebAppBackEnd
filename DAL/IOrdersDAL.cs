using DAL.Entities;

namespace DAL
{
    public interface IOrdersDAL
    {
        Task<List<Order>> GetAllOrders();
    }
}