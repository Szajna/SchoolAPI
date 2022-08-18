using MediatR;

namespace SchoolAPI.Commands
{
    public class DeleteGroupCommand : IRequest<Group>
    {
        public string Id { get; }

        public DeleteGroupCommand(string id)
        {
            Id = id;
        }
    }
}
