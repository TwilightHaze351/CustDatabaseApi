using Microsoft.AspNetCore.Mvc;
using CustDatabaseApi.Server.Models;
using CustDatabaseApi.Server.Data;
using System.Linq;

namespace CustDatabaseApi.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CustomersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customers = _context.Customers.ToList();
            return Ok(customers);
        }

        // Additional methods (POST, PUT, DELETE) can be added here to handle Create, Update, Delete
    }
}
