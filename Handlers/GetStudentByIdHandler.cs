using MediatR;
using SchoolAPI.Queries;

namespace SchoolAPI.Handlers
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
    {
        private readonly IStudentService _studentService;

        public GetStudentByIdHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<Student> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {

            var student = await _studentService.GetStudent(request.Id);
            if (student == null)
            {
                return null;
            }
            return student;
        }
    }
}
