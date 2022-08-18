using MediatR;
using SchoolAPI.Contracts;
using SchoolAPI.Queries;

namespace SchoolAPI.Handlers
{
    public class GetGroupByIdHandler : IRequestHandler<GetGroupByIdQuery, Group>
    {
        private readonly IGroupService _groupService;

        public GetGroupByIdHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<Group> Handle(GetGroupByIdQuery request, CancellationToken cancellationToken)
        {
            var group = await _groupService.GetGroup(request.Id);
            if(group == null)
            {
                return null;
            }
            return group;
        }
    }
}
