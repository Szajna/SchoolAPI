using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;
using SchoolAPI.Services;
using SchoolAPI.Queries;
using MediatR;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;
        private readonly IMediator _mediator;
        public StudentController(IStudentService studentService, IMediator mediator)
        {
            this.studentService = studentService;
            _mediator = mediator;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            var query = new GetAllStudentsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
            
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Student>> GetStudent(string studentId)
        {
            var query = new GetStudentByIdQuery(studentId);
            var result = await _mediator.Send(query);
            return result != null ? Ok(result) : NotFound();
        }
        [HttpPost]
        public async Task<ActionResult<Student>> AddStudent(Student student)
        {
            var result = await _mediator.Send(student);
            return Ok(student);
        }

        [HttpPut]
        public async Task<ActionResult<List<Student>>> UpdateStudent(Student request)
        {
            return Ok(await studentService.UpdateStudent(request));
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(string Id)
        {
            return Ok(await studentService.DeleteStudent(Id));
        }
    }
}
