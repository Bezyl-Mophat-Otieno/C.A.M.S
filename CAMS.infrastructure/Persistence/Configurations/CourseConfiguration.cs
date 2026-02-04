using CAMS.domain.Courses;
using CAMS.domain.ValueValidationTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassAttendanceManagementSystem.Persistence.Configurations;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses").HasKey(c => c.Id);
        builder.Property(c => c.CourseName).HasConversion(
            name => name.Value,
            value => CourseName.From(value)
            ).IsRequired();
        builder.Property(c => c.CourseCode).HasConversion(
            code => code.Value,
            value => CourseCode.From(value)
            ).IsRequired();
        builder.Property(c => c.CourseDuration).HasConversion(
            duration => duration.Value,
            value => CourseDuration.From(value)
        ).IsRequired();
        builder.HasIndex(c => c.CourseName).IsUnique();
        builder.HasIndex(c => c.CourseCode).IsUnique();
    }
}