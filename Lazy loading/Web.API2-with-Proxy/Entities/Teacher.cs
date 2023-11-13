namespace Web.API2_with_Proxy.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual List<Student>? Students {  get; set; }
    }
}
