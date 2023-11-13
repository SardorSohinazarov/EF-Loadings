using ConsoleApp1.Data;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        AppDbContext appDbContext = new AppDbContext(new DbContextOptions<AppDbContext>());

        var student = appDbContext.Students.First();

        Console.WriteLine(student.Name);

        Console.WriteLine(student.Address.Country);
    }
}