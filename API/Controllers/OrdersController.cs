using BL;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        public IOrdersBL _ordersBL; //משתנה ליצירת התלות בממשק הבי אל

        public OrdersController(IOrdersBL ordersBL) //ctor
        {
            _ordersBL = ordersBL;
        }
        

        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<List<Order>> GetAllOrders()
        {
            var Order = await _ordersBL.GetAllOrders(); //פה ובפרודוקט לא מזהה את הואר לפי טיפוס אורדר
            return Order;
        }


        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
