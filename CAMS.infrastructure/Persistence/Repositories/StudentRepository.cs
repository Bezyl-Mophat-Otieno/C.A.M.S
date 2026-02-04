using CAMS.application.Abstractions.Persistence;
using CAMS.Application.Common.Exceptions;
using CAMS.domain.ValueValidationTypes;
using CAMS.infrastructure.Persistence;
using CAMS.infrastructure.Persistence.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace ClassAttendanceManagementSystem.Persistence.Repositories;

public class StudentRepository : IStudentRepository
{
    public AppDbContext _dbContext;

    public StudentRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(Student student)
    {
        try
        {
            await _dbContext.Students.AddAsync(student);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw EfcoreExceptionTranslator.Translate(e);
        }
    }

    public async Task<Student?> GetStudentByIdAsync(StudentId studentId)
    {
        try
        {
            return await _dbContext.Students.FindAsync(studentId);
        }
        catch (Exception e)
        {
            throw EfcoreExceptionTranslator.Translate(e);
            ;
        }
    }

    public async Task<bool> CheckStudentExistByEmail(EmailAddress studentEmail)
    {
        try
        {
            return await _dbContext.Students.AnyAsync(s => s.Email == studentEmail);
        }
        catch (Exception e)
        {
            throw EfcoreExceptionTranslator.Translate(e);
        }

    }
}