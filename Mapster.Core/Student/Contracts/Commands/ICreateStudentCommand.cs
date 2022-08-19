using Mapster.Core.Student.Transports;
using Mapster.Shared.Contracts.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Core.Student.Contracts.Commands
{
    public interface ICreateStudentCommand : ICreateHandler<StudentTransport>
    {
    }
}
