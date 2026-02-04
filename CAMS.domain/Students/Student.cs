using CAMS.domain.Courses;

namespace CAMS.domain.ValueValidationTypes;


public class Student
{
    public StudentId Id { get; private set; }
    public StudentName FirstName { get; private set; }
    public StudentName LastName { get; private set; }

    public EmailAddress Email { get; private set; }
    public CourseId CourseId { get; private set; }

    public Course Course { get; private set; } = null; // navigation property
    public int YearOfStudy { get; private set; }

    private Student(StudentId id, StudentName firstName, StudentName lastName, EmailAddress email, CourseId courseId, int yearOfStudy)
    {
        if (yearOfStudy < 1)
        {
            throw new ArgumentException("Year of Study must be at least 1");
        }

        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        CourseId = courseId;
        YearOfStudy = yearOfStudy;
    }

    public static Student New(StudentName firstName, StudentName lastName, EmailAddress email, CourseId courseId, int yearOfStudy) => new(
        StudentId.New(),
        firstName,
        lastName,
        email,
        courseId,
        yearOfStudy
        );

}