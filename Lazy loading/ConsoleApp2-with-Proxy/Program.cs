using ConsoleApp2_with_Proxy.Data;
using Microsoft.EntityFrameworkCore;

AppDbContext appDbContext = new AppDbContext(new DbContextOptions<AppDbContext>());

var student = appDbContext.Students.First();

Console.WriteLine(student.Name);

Console.WriteLine(student.Address.Country);