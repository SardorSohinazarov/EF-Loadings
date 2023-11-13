using Web.API2_with_Proxy.Entities;

namespace Web.API2_with_Proxy.Configurations
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
