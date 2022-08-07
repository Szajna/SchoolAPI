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
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> Get()
        {
            return Ok(_studentService.Get());
        }
        [HttpGet("{LastName}")]
        public async Task<ActionResult<Student>> Get(string LastName)
        {
            return Ok(_studentService.Get(LastName));
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            return Ok(_studentService.AddStudent(student));
        }

        [HttpPut]
        public async Task<ActionResult<List<Student>>> UpdateStudent(Student request)
        {
            return Ok(_studentService.UpdateStudent(request));
        }

        [HttpDelete("{LastName}")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(string LastName)
        {
            return Ok(_studentService.DeleteStudent(LastName));
        }
    }
}
