using MediatR;

namespace SchoolAPI.Commands
{
    public class AddStudentsToGroupCommand : IRequest<Group>
    {
        public string GroupId { get; }
        public List<string> Students { get; }

        public AddStudentsToGroupCommand(string groupId, List<string> students)
        {
            GroupId = groupId;
            Students = students;
        }
    }
}
