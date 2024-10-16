using DAL.Entities;

namespace BL
{
    public interface IUsersBL
    {
        Task<List<User>> GetAllUsers();
    }
}