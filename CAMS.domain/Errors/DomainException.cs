namespace ClassAttendanceManagementSystem.Errors;

public abstract class DomainException : Exception
{
    protected DomainException(string errorMessage) : base(errorMessage)
    {

    }

}