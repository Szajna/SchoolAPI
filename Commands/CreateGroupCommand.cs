using MediatR;

namespace SchoolAPI.Commands
{
    public class CreateGroupCommand : IRequest<Group>
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Supervisor { get; set; }

        public CreateGroupCommand(Group group)
        {
            Name = group.Name;
            Year = group.Year;
            Supervisor = group.Supervisor;
        }
    }
}
