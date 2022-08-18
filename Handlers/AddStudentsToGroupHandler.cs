using MediatR;
using SchoolAPI.Commands;
using SchoolAPI.Contracts;

namespace SchoolAPI.Handlers
{
    public class AddStudentsToGroupHandler : IRequestHandler<AddStudentsToGroupCommand, Group>
    {
        private readonly IGroupService _groupService;

        public AddStudentsToGroupHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<Group> Handle(AddStudentsToGroupCommand request, CancellationToken cancellationToken)
        {
                        
            var group = await _groupService.AddStudentsToGroup(request.GroupId, request.StudentId);
            return group;
        }
    }
}
