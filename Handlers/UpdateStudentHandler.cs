using MediatR;
using SchoolAPI.Commands;

namespace SchoolAPI.Handlers
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, Student>
    {
        private readonly IStudentService _studentService;

        public UpdateStudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<Student> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var studentToUpdate = new Student
            {
                Address = request.Address,
                Birthdate = request.Birthdate,
                City = request.City,
                LastName = request.LastName,
                FatherName = request.FatherName,
                FirstName = request.FirstName,
                PostCode = request.PostCode,
            };
            var student = await _studentService.UpdateStudent(studentToUpdate);
            return student;
        }
    }
}
