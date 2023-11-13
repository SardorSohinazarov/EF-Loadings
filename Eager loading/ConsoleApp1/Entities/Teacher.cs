namespace ConsoleApp1.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Student>? Students { get; set; }
    }
}
