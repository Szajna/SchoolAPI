using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Queries;
using MediatR;
using SchoolAPI.Commands;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            return Ok(await _mediator.Send(new GetAllStudentsQuery()));
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Student>> GetStudent(string studentId)
        {
            var query = new GetStudentByIdQuery(studentId);
            var result = await _mediator.Send(query);
            return (result != null) ? Ok(result) : NotFound();
            //return await _mediator.Send(new GetStudentByIdQuery(studentId)) != null ? Ok(await _mediator.Send(new GetStudentByIdQuery(studentId))) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(Student student)
        {
            var query = new CreateStudentCommand(student);
            var result = await _mediator.Send(query);
            return (result != null) ? Ok(result) : NotFound();
            //return await _mediator.Send(new CreateStudentCommand(student)) != null ? Ok(await _mediator.Send(new CreateStudentCommand(student))) : NotFound();
        }

        [HttpPut]
        public async Task<ActionResult<Student>> UpdateStudent(Student request)
        {
            var query = new UpdateStudentCommand(request);
            var result = await _mediator.Send(query);
            return (result != null) ? Ok(result) : NotFound();
            //return await _mediator.Send(new UpdateStudentCommand(request)) != null ? Ok(await _mediator.Send(new UpdateStudentCommand(request))) : NotFound();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Student>> DeleteStudent(string Id)
        {
            var query = new DeleteStudentCommand(Id);
            var result = await _mediator.Send(query);
            return (result != null) ? Ok(result) : NotFound();
            //return await _mediator.Send(new DeleteStudentCommand(Id)) != null ? Ok(await _mediator.Send(new DeleteStudentCommand(Id))) : NotFound();
        }
    }
}
