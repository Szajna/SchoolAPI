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

        public async Task<List<Student>> AddStudent(Student student)
        {
            context.Students.Add(student);

            await context.SaveChangesAsync();
            return await context.Students.ToListAsync();
        }

        public async Task<List<Student>> DeleteStudent(string Id)
        {
            var DbStudent = await context.Students.FindAsync(Id);

            context.Students.Remove(DbStudent);

            await context.SaveChangesAsync();
            return await context.Students.ToListAsync();
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

        public async Task<List<Student>> UpdateStudent(Student request)
        {
            var DbStudent = await context.Students.FindAsync(request.LastName);

            DbStudent.Id = request.Id;
            DbStudent.FirstName = request.FirstName;
            DbStudent.LastName = request.LastName;
            DbStudent.Address = request.Address;
            DbStudent.City = request.City;
            DbStudent.PostCode = request.PostCode;

            await context.SaveChangesAsync();
            return await context.Students.ToListAsync();
        }
    }
}
