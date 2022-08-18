using SchoolAPI.Models;
using SchoolAPI.Data;

namespace SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;
        public StudentService(DataContext context)
        {
            _context = context;
        }

        public async Task<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);

            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student> DeleteStudent(string Id)
        {
            var DbStudent = await _context.Students.FindAsync(Id);

            _context.Students.Remove(DbStudent);

            await _context.SaveChangesAsync();
            return DbStudent;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudent(string Id)
        {
            var student = await _context.Students.FindAsync(Id);
            
            return student;
        }

        public async Task<Student> UpdateStudent(Student request)
        {
            var DbStudent = await _context.Students.FindAsync(request.Id);

            DbStudent.FirstName = request.FirstName;
            DbStudent.LastName = request.LastName;
            DbStudent.Address = request.Address;
            DbStudent.City = request.City;
            DbStudent.PostCode = request.PostCode;

            await _context.SaveChangesAsync();
            return request;
        }
    }
}
