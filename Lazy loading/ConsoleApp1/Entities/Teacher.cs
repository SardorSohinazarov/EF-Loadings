using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ConsoleApp1.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Teacher()
        {

        }

        private ILazyLoader _lazyLoader;
        public Teacher(ILazyLoader lazyLoader)
        {
            _lazyLoader = lazyLoader;
        }

        private List<Student>? _students;
        public List<Student>? Students
        {
            get => _lazyLoader.Load(this, ref _students);
            set => _students = value;
        }
    }
}
