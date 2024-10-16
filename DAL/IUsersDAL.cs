using DAL.Entities;

namespace DAL
{
    public interface IUsersDAL
    {
        Task<List<User>> GetAllUsers();
    }
}