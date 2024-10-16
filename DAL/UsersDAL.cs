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

        public ShopContext _context;//יצירת תלות במחלקה האחראית על הגישה דטה בייס
        public UsersDAL(ShopContext context)
        {
            _context = context;
        }
        //פונקצית שליפת כל היוזרים
        public async Task<List<User>> GetAllUsers()
        {
            List<User> usersList = await _context.Users.ToListAsync(); //צריך להתאים סוג קריאה אסינק עם פונקציית קור אסינק
            return usersList;
        }
    }
}
