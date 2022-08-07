using SchoolAPI.Models;

namespace SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;
        public StudentService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Student>> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return await _context.Students.ToListAsync();
        }

        public async Task<List<Student>> DeleteStudent(string LastName)
        {
            var DbStudent = await _context.Students.FindAsync(LastName);
            if (DbStudent == null)
                return BadRequest("Student not found.");
            _context.Students.Remove(DbStudent);

            await _context.SaveChangesAsync();

            return await _context.Students.ToListAsync();
        }

        public async Task<List<Student>> Get()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> Get(string LastName)
        {
            var student = await _context.Students.FindAsync(LastName);
            if (student == null)
                return BadRequest("Student not found.");
            return student;
        }

        public async Task<List<Student>> UpdateStudent(Student request)
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

            return await _context.Students.ToListAsync();
        }
    }
}
