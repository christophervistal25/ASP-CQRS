using Mapster.Infrastructure.Contracts;
using Mapster.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Infrastructure.DatabaseContext
{
    public class ApplicationDatabaseContext :DbContext, IApplicationDatabaseContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) :base(options)
        {}

        public DbSet<Student> Student { get; set; }
   
    }
}
