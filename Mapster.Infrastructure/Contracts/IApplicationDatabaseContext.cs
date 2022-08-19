
using Microsoft.EntityFrameworkCore;

using Mapster.Model;

namespace Mapster.Infrastructure.Contracts
{
    public interface IApplicationDatabaseContext
    {
        DbSet<Student> Student { get; set; }
    }
}
