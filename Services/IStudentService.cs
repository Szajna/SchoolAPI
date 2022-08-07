using SchoolAPI.Models;

namespace SchoolAPI.Services
{
    public interface IStudentService
    {
        Task<List<Student>> AddStudent(Student student);
        Task<List<Student>> DeleteStudent(string LastName);
        Task<List<Student>> Get();
        Task<Student> Get(string LastName);
        Task<List<Student>> UpdateStudent(Student request);
    }
}
