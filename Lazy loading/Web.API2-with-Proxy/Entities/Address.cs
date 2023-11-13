namespace Web.API2_with_Proxy.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual List<Student>? Students { get; set; }
    }
}
