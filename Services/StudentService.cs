using SchoolAPI.Models;
using SchoolAPI.Data;

namespace SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly DataContext context;
        public StudentService(DataContext context)
        {
            this.context = context;
        }

        public async Task<Student> AddStudent(Student student)
        {
            context.Students.Add(student);

            await context.SaveChangesAsync();
            return student;
        }

        public async Task<Student> DeleteStudent(string Id)
        {
            var DbStudent = await context.Students.FindAsync(Id);

            context.Students.Remove(DbStudent);

            await context.SaveChangesAsync();
            return DbStudent;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            return await context.Students.ToListAsync();
        }

        public async Task<Student> GetStudent(string Id)
        {
            var student = await context.Students.FindAsync(Id);
            
            return student;
        }

        public async Task<Student> UpdateStudent(Student request)
        {
            var DbStudent = await context.Students.FindAsync(request.LastName);

            DbStudent.FirstName = request.FirstName;
            DbStudent.LastName = request.LastName;
            DbStudent.Address = request.Address;
            DbStudent.City = request.City;
            DbStudent.PostCode = request.PostCode;

            await context.SaveChangesAsync();
            return request;
        }
    }
}
