using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web.API1.Data;
using Web.API1.Entities;

namespace Web.API1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _context.Students
                .Include(x => x.Teachers)
                .ToListAsync();

            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Student student)
        {
            var entityentry = await _context.Students.AddAsync(student);

            await _context.SaveChangesAsync();

            return Ok(entityentry.Entity);
        }
    }
}
