using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ConsoleApp1.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int AddressId { get; set; }

        public Student()
        {

        }

        private ILazyLoader _lazyLoader;
        public Student(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        private Address? _address;
        public Address? Address
        {
            get => _lazyLoader.Load(this, ref _address);
            set => _address = value;
        }

        private List<Teacher>? _teachers;
        public List<Teacher>? Teachers
        {
            get => _lazyLoader.Load(this, ref _teachers);
            set => _teachers = value;
        }
    }
}
