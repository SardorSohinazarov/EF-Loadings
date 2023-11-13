namespace Web.API2_with_Proxy.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int AddressId { get; set; }

        public virtual Address? Address { get; set; }
        public virtual List<Teacher>? Teachers { get; set; }
    }
}
