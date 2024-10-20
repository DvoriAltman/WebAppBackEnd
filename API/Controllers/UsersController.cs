using BL;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        public IUsersBL _usersBL; 

        public UsersController(IUsersBL usersBL) //ctor
        {
            _usersBL = usersBL;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public async Task<List<User>> GetAllUsers()
        {
            var User = await _usersBL.GetAllUsers();
            return User;
        }


        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
