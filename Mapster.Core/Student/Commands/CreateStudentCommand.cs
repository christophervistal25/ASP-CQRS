using Mapster.Core.Student.Contracts.Commands;
using Mapster.Core.Student.Contracts.Mapper;
using Mapster.Core.Student.Transports;
using Mapster.Infrastructure.DatabaseContext;

namespace Mapster.Core.Student.Commands
{
    public class CreateStudentCommand :ICreateStudentCommand
    {
        private readonly ApplicationDatabaseContext _Context;
        private readonly IStudentMapper _Mapper;

        public CreateStudentCommand(ApplicationDatabaseContext context, IStudentMapper mapper)
        {
            _Context = context;
            _Mapper = mapper;
        }

        public void Handle(StudentTransport entity)
        {
            var student = _Mapper.ToEntity(entity);
            _Context.Student.Add(student);
            _Context.SaveChanges();

        }
    }
}
