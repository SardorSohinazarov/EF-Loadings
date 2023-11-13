﻿using Microsoft.AspNetCore.Mvc;
using Web.API2_with_Proxy.Data;
using Web.API2_with_Proxy.Entities;

namespace Web.API2_with_Proxy.Controllers
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
