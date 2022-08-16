using MediatR;

namespace SchoolAPI.Commands
{
    public class DeleteStudentCommand : IRequest<Student>
    {
        public string Id { get; }

        public DeleteStudentCommand(string id)
        {
            Id = id;
        }
    }
}
