using Mapster.Core.Student.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Core.Student.Contracts.Mapper
{
    public interface IStudentMapper
    {
        // Transport to Student
        public Model.Student ToEntity(StudentTransport studentTransport);

        // List of students to List of Transports
        public IEnumerable<StudentTransport> ToTransportList(List<Model.Student> students);

        // Student to Transport
        public StudentTransport ToTransport(Model.Student student);
    }
}
