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
        public IUsersDAL _usersDAL; 
        public IMapper _mapper; 
        public UsersBL(IUsersDAL usersDAL, IMapper mapper) //ctor
        {
            _usersDAL = usersDAL;
            _mapper = mapper;
        }

        public async Task<List<User>> GetAllUsers()
        { 
            List<User> users = await _usersDAL.GetAllUsers();
            return users;
        }
    }
}
