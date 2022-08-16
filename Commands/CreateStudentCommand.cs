using MediatR;

namespace SchoolAPI.Commands
{
    public class CreateStudentCommand : IRequest<Student>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string FatherName { get; set; }
    }
}
