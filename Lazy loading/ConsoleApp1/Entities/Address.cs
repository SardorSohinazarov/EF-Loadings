namespace ConsoleApp1.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public List<Student>? Students { get; set; }
    }
}
