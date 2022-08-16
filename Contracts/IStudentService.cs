using SchoolAPI.Models;

namespace SchoolAPI.Services
{
    public interface IStudentService
    {
        Task<Student> AddStudent(Student student);
        Task<Student> DeleteStudent(string Id);
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudent(string Id);
        Task<Student> UpdateStudent(Student request);
    }
}
