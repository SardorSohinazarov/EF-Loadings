using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.API1.Data;
using Web.API1.Entities;

namespace Web.API1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AddressesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var addresses = await _context.Addresses
                .ToListAsync();

            return Ok(addresses);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _context.Addresses
                .Select(x => x.Students)
                .ToListAsync();

            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Address address)
        {
            var entityentry = await _context.Addresses.AddAsync(address);
            await _context.SaveChangesAsync();

            return Ok(entityentry.Entity);
        }
    }
}
