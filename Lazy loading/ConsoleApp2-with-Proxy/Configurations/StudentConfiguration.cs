using ConsoleApp2_with_Proxy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp2_with_Proxy.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasMany(x => x.Teachers)
                .WithMany(x => x.Students)
                .UsingEntity<StudentTeacher>();
        }
    }
}
