using CAMS.application.Abstractions.Persistence;
using CAMS.domain.Courses;
using CAMS.domain.ValueValidationTypes;

namespace ClassAttendanceManagementSystem.Persistence.Repositories;

public class CourseRepository : ICourseRepository
{
    public Task<Course> AddCourseAsync(Course course)
    {
        throw new NotImplementedException();
    }

    public Task<Course?> GetByNameAsync(CourseName courseName)
    {
        throw new NotImplementedException();
    }

    public Task<Course?> GetCourseByIdAsync(CourseId courseId)
    {
        throw new NotImplementedException();
    }
}