using MediatR;
using SchoolAPI.Commands;
using SchoolAPI.Contracts;

namespace SchoolAPI.Handlers
{
    public class UpdateGroupHandler : IRequestHandler<UpdateGroupCommand, Group>
    {
        private readonly IGroupService _groupService;

        public UpdateGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<Group> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
        {
            var groupToUpdate = new Group
            {
                Name = request.Name,
                Year = request.Year,
                Supervisor = request.Supervisor
            };
            var group = await _groupService.UpdateGroup(groupToUpdate);
            return group;
        }
    }
}
