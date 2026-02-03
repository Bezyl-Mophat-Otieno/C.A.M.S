using CAMS.application.Abstractions.Persistence;
using CAMS.domain.ValueValidationTypes;

namespace ClassAttendanceManagementSystem.Persistence.Repositories;

public class StudentRepository : IStudentRepository
{
    public Task AddAsync(Student student)
    {
        throw new NotImplementedException();
    }

    public Task<Student?> GetStudentByIdAsync(StudentId studentId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CheckStudentExistByEmail(EmailAddress studentEmail)
    {
        throw new NotImplementedException();
    }
}