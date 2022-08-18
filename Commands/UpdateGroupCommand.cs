using MediatR;

namespace SchoolAPI.Commands
{
    public class UpdateGroupCommand : IRequest<Group>
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Supervisor { get; set; }

        public UpdateGroupCommand(Group group)
        {
            Name = group.Name;
            Year = group.Year;
            Supervisor = group.Supervisor;
        }
    }
}
