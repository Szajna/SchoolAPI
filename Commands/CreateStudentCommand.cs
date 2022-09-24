using MediatR;

namespace SchoolAPI.Commands
{
    public class CreateStudentCommand : IRequest<Student>
    {
        public string LastName { get; }
        public string FirstName { get; }
        public DateTime Birthdate { get; }
        public string Address { get; }
        public string PostCode { get; }
        public string City { get; }
        public string FatherName { get; }
        public string GroupId { get; set; }
        public CreateStudentCommand(Student student)
        {
            FirstName = student.FirstName;
            LastName = student.LastName;
            Birthdate = DateTime.Now;
            Address = student.Address;
            PostCode = student.PostCode;
            City = student.City;
            FatherName = student.FatherName;
            GroupId = student.GroupId;
        }
    }
}
