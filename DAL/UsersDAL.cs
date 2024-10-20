using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersDAL : IUsersDAL
    {

        public ShopContext _context;
        public UsersDAL(ShopContext context)
        {
            _context = context;
        }
   
        public async Task<List<User>> GetAllUsers()
        {
            List<User> usersList = await _context.Users.ToListAsync(); 
            return usersList;
        }
    }
}
