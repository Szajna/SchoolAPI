using MediatR;
using SchoolAPI.Commands;
using SchoolAPI.Contracts;

namespace SchoolAPI.Handlers
{
    public class DeleteGroupHandler : IRequestHandler<DeleteGroupCommand, Group>
    {
        private readonly IGroupService _groupService;

        public DeleteGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<Group> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
        {
            var group = await _groupService.DeleteGroup(request.Id);
            if(group == null)
            {
                return null;
            }
            return group;
        }
    }
}
