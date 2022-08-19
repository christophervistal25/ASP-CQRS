using Mapster.Core.Student.Transports;
using Mapster.Shared.Contracts.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Core.Student.Contracts.Queries
{
    public interface IGetAllStudentQuery :IGetAllHandler<StudentTransport>
    {

    }
}
