namespace CAMS.infrastructure.Persistence.Exceptions;

public abstract class DbException : Exception
{
    public DbException(string errorMessage, Exception innerException) : base(errorMessage, innerException)
    {
    }

}