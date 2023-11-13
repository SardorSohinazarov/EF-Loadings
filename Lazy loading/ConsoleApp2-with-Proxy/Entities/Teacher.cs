using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ConsoleApp2_with_Proxy.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual List<Student>? Students { get; set; }
    }
}
