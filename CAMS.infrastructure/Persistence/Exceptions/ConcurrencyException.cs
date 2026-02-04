using CAMS.infrastructure.Persistence.Exceptions;

public sealed class ConcurrencyException : DbException
{
    public ConcurrencyException(string message, Exception innerException)
        : base(message, innerException) { }
}