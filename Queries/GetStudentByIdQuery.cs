using MediatR;

namespace SchoolAPI.Queries
{
    public class GetStudentByIdQuery : IRequest<Student>
    {
        public string Id { get; }

        public GetStudentByIdQuery(string id)
        {
            Id = id;
        }
    }
}
