using MediatR;

namespace SchoolAPI.Commands
{
    public class UpdateStudentCommand : IRequest<Student>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string FatherName { get; set; }
        public UpdateStudentCommand(Student student)
        {
            FirstName = student.FirstName;
            LastName = student.LastName;
            Birthdate = student.Birthdate;
            Address = student.Address;
            PostCode = student.PostCode;
            City = student.City;
            FatherName = student.FatherName;
        }
    }
}
