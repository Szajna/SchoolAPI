using MediatR;

namespace SchoolAPI.Queries
{
    public class GetAllStudentsQuery : IRequest<List<Student>>
    {
    }
}
