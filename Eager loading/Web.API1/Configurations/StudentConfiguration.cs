using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Web.API1.Entities;

namespace Web.API1.Configurations
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
