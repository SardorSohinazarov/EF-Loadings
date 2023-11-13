using ConsoleApp1.Data;
using Microsoft.EntityFrameworkCore;

AppDbContext appDbContext = new AppDbContext(new DbContextOptions<AppDbContext>());

var student = appDbContext.Students.Include(x => x.Teachers).First();

Console.WriteLine(student.Name);

Console.WriteLine(student.Teachers[0].Name);