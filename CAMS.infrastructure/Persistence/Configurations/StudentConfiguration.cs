using CAMS.domain.ValueValidationTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClassAttendanceManagementSystem.Persistence.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students").HasKey(s => s.Id);
        builder.Property(s => s.Id).HasConversion(
            id => id.Value,
            value => StudentId.From(value)
        ).ValueGeneratedNever();

        builder.Property(s => s.FirstName).HasConversion(
            firstName => firstName.Value,
            value => StudentName.From(value)
        ).IsRequired();
        builder.Property(s => s.LastName).HasConversion(
            lastName => lastName.Value,
            value => StudentName.From(value)
        ).IsRequired();

        builder.Property(s => s.Email).HasConversion(
            address => address.Value,
            value => EmailAddress.From(value)
        ).IsRequired();

        builder.Property(s => s.Email).HasConversion(
           address => address.Value,
           value => EmailAddress.From(value)
            ).IsRequired();
        builder.Property(s => s.CourseId).HasConversion(
            courseId => courseId.Value,
            value => CourseId.From(value)
        ).IsRequired();
        builder.Property(s => s.YearOfStudy).IsRequired();
        builder.HasOne(s => s.Course).WithMany(s => s.Students).HasForeignKey(s => s.CourseId);
        builder.HasIndex(s => s.Email).IsUnique();
    }

}