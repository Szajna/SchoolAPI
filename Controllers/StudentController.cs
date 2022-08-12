using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;
using SchoolAPI.Services;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Student>>> GetAllStudents()
        {
            return Ok(await studentService.GetAllStudents());
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Student>> GetStudent(string Id)
        {
            return Ok(await studentService.GetStudent(Id));
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            return Ok(await studentService.AddStudent(student));
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
