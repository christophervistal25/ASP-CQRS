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
    public class GetAllStudentQuery :IGetAllStudentQuery
    {
        private readonly ApplicationDatabaseContext _Context;
        private readonly IStudentMapper _Mapper;

        public GetAllStudentQuery(ApplicationDatabaseContext context, IStudentMapper mapper)
        {
            _Context = context;
            _Mapper = mapper;
        }

        public IEnumerable<StudentTransport> GetAll()
        {
            var students = _Context.Student.ToList(); 
            return _Mapper.ToTransportList(students);
        }
    }
}
