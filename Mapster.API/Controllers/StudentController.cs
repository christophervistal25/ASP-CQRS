using Mapster.Core.Student.Contracts;
using Mapster.Core.Student.Contracts.Commands;
using Mapster.Core.Student.Contracts.Queries;
using Mapster.Core.Student.Transports;
using Mapster.Infrastructure.DatabaseContext;
using Mapster.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mapster.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly ICreateStudentCommand _CreateStudentCommand;
        private readonly IGetStudentQuery _GetStudentQuery;
        private readonly IGetAllStudentQuery _GetStudentAllQuery;

        public StudentController(ICreateStudentCommand createStudentCommand, IGetStudentQuery getStudentQuery, IGetAllStudentQuery getStudentAllQuery)
        {
            _CreateStudentCommand = createStudentCommand;
            _GetStudentQuery = getStudentQuery;
            _GetStudentAllQuery = getStudentAllQuery;
        }


        [HttpGet(template: nameof(GetStudents), Name = nameof(GetStudents))]
        public ActionResult GetStudents()
        {
            return Ok(_GetStudentAllQuery.GetAll());
        }


        [HttpGet(template: nameof(GetStudent), Name = nameof(GetStudent))]
        public ActionResult GetStudent(int id)
        {
            return Ok(_GetStudentQuery.Get(id));
        }

        [HttpPost]
        public ActionResult AddStudent(StudentTransport student)
        {
            _CreateStudentCommand.Handle(student);
            return CreatedAtAction(nameof(GetStudent), student.Id);
        }

    }
}
