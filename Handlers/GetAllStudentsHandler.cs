using MediatR;
using SchoolAPI.Queries;

namespace SchoolAPI.Handlers
{
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudentsQuery, List<Student>>
    {
        private readonly IStudentService _studentService;

        public GetAllStudentsHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<List<Student>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetAllStudents();
        }
    }
}