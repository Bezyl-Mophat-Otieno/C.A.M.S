using CAMS.infrastructure.Persistence.Exceptions;

namespace CAMS.Application.Common.Exceptions;

public sealed class PersistenceException : DbException
{
    public PersistenceException(string message, Exception innerException)
        : base(message, innerException) { }
}