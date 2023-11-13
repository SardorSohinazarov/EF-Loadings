using Microsoft.AspNetCore.Mvc;
using Web.API2_with_Proxy.Data;
using Web.API2_with_Proxy.Entities;

namespace Web.API2_with_Proxy.Controllers
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
            var students = await _context.Students.ToListAsync();

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
