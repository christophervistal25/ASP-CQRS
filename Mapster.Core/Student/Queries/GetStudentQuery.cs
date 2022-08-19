using Mapster.Core.Student.Contracts.Mapper;
using Mapster.Core.Student.Contracts.Queries;
using Mapster.Core.Student.Transports;
using Mapster.Infrastructure.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Core.Student.Queries
{
    public class GetStudentQuery : IGetStudentQuery
    {
        private readonly ApplicationDatabaseContext _Context;
        private readonly IStudentMapper _Mapper;

        public GetStudentQuery(ApplicationDatabaseContext context, IStudentMapper mapper)
        {
            _Context = context;
            _Mapper = mapper;
        }

        public StudentTransport Get(int id)
        {
            var student = _Context.Student.Where(student => student.Id == id).First();
            return _Mapper.ToTransport(student);
        }
    }
}
