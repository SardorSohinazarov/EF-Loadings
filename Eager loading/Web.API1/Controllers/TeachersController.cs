using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.API1.Data;
using Web.API1.Entities;

namespace Web.API1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TeachersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var teachers = await _context.Teachers
                .Include(x => x.Students)
                .ToListAsync();

            return Ok(teachers);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Teacher teacher)
        {
            var entityentry = await _context.Teachers.AddAsync(teacher);

            await _context.SaveChangesAsync();

            return Ok(entityentry.Entity);
        }
    }
}
