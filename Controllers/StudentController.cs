using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _context;
        public StudentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> Get()
        {
            return Ok(await _context.Students.ToListAsync());
        }
        [HttpGet("{LastName}")]
        public async Task<ActionResult<Student>> Get(string LastName)
        {
            var student = await _context.Students.FindAsync(LastName);
            if (student == null)
                return BadRequest("Student not found.");
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok(await _context.Students.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Student>>> UpdateStudent(Student request)
        {
            var DbStudent = await _context.Students.FindAsync(request.LastName);
            if (DbStudent == null)
                return BadRequest("Student not found.");

            DbStudent.FirstName = request.FirstName;
            DbStudent.LastName = request.LastName;
            DbStudent.Address = request.Address;
            DbStudent.City = request.City;
            DbStudent.PostCode = request.PostCode;

            await _context.SaveChangesAsync();

            return Ok(await _context.Students.ToListAsync());
        }

        [HttpDelete("{LastName}")]
        public async Task<ActionResult<List<Student>>> DeleteStudent(string LastName)
        {
            var DbStudent = await _context.Students.FindAsync(LastName);
            if (DbStudent == null)
                return BadRequest("Student not found.");
            _context.Students.Remove(DbStudent);

            await _context.SaveChangesAsync();

            return Ok(await _context.Students.ToListAsync());
        }
    }
}
