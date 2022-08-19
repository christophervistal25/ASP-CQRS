using Mapster.Core.Student.Contracts.Mapper;
using Mapster.Core.Student.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapster.Core.Student.Mapper
{
    public class StudentMapper : IStudentMapper
    {
        public Model.Student ToEntity(StudentTransport studentTransport)
        {
            var student = new Model.Student
            {
                Id = studentTransport.Id,
                FirstName = studentTransport.FirstName,
                LastName = studentTransport.LastName,
                MiddleName = studentTransport.MiddleName,
                Suffix = studentTransport.Suffix,
                CreatedAt = studentTransport.CreatedAt,
                UpdatedAt = studentTransport.UpdatedAt,
            };

            return student;
        }

        public StudentTransport ToTransport(Model.Student student)
        {

            var studentTransport = new StudentTransport()
            {
                Id = student.Id,
                Fullname = $"{student.LastName}, {student.FirstName} {student.MiddleName} {student.Suffix}",
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                Suffix = student.Suffix,
                CreatedAt = student.CreatedAt,
                UpdatedAt = student.UpdatedAt
            };

            return studentTransport;
        }

        public IEnumerable<StudentTransport> ToTransportList(List<Model.Student> students)
        {
            var listOfTransportedStudents = new List<StudentTransport>();

            students.ForEach((student) => listOfTransportedStudents.Add(ToTransport(student)));

            return listOfTransportedStudents;
        }
    }
}
