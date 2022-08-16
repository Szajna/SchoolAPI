using MediatR;
using SchoolAPI.Commands;

namespace SchoolAPI.Handlers
{
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand, Student>
    {
        private readonly IStudentService _studentService;

        public DeleteStudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<Student> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _studentService.DeleteStudent(request.Id);
            if (student == null)
            {
                return null;
            }
            return student;
        }
    }
}
