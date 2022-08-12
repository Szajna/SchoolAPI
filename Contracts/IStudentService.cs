using SchoolAPI.Models;

namespace SchoolAPI.Services
{
    public interface IStudentService
    {
        Task<List<Student>> AddStudent(Student student);
        Task<List<Student>> DeleteStudent(string Id);
        Task<List<Student>> GetAllStudents();
        Task<Student> GetStudent(string Id);
        Task<List<Student>> UpdateStudent(Student request);
    }
}
