using AutoMapper;
using DAL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UsersBL : IUsersBL
    {
        public IUsersDAL _usersDAL; //יצרנו תלות לממשק של הדל כדי לשמור על הכימוס
        public IMapper _mapper; // תלות בממשק איי מאפר כדי להשתמש בדיטיאו
        public UsersBL(IUsersDAL usersDAL, IMapper mapper) //ctor
        {
            _usersDAL = usersDAL;
            _mapper = mapper;
        }

        public async Task<List<User>> GetAllUsers()
        { // הפעלת הפונקציה משכבת הדאל עי המשתמש של התלות
            List<User> users = await _usersDAL.GetAllUsers();
            return users;
        }
    }
}
