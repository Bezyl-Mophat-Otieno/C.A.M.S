using System.Data;
using CAMS.Application.Common.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace CAMS.infrastructure.Persistence.Exceptions;

public class EfcoreExceptionTranslator
{
    public static DbException Translate(Exception e) =>
        e switch
        {
            DBConcurrencyException ex => new ConcurrencyException("The data was modified by another operation.", ex),
            DbUpdateException ex => new PersistenceException("A database error occurred while saving data.", ex),
            _ => new PersistenceException("An unexpected persistence error occurred", e)

        };
}