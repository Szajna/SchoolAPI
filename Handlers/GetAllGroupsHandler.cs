using MediatR;
using SchoolAPI.Contracts;
using SchoolAPI.Queries;

namespace SchoolAPI.Handlers
{
    public class GetAllGroupsHandler : IRequestHandler<GetAllGroupsQuery, List<Group>>
    {
        private readonly IGroupService _groupService;
        public GetAllGroupsHandler(IGroupService groupService)
        {
            _groupService = groupService;
        }

        public async Task<List<Group>> Handle(GetAllGroupsQuery request, CancellationToken cancellationToken)
        {
            return await _groupService.GetAllGroups();
        }
    }
}
