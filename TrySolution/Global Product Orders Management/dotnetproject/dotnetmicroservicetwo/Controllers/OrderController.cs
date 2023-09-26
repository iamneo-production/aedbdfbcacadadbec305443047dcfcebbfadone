using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetmicroservicetwo.Models;

namespace dotnetmicroservicetwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext _context;

        public OrderController(OrderDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            var orders = await _context.Orders.ToListAsync();
            return Ok(orders);
        }

        [HttpPost]
        public async Task<ActionResult> AddOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return detailed validation errors
            }
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid Order id");

            var order = await _context.Orders.FindAsync(id);
              _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
