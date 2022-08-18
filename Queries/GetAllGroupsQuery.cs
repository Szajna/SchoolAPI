using MediatR;

namespace SchoolAPI.Queries
{
    public class GetAllGroupsQuery : IRequest<List<Group>>
    {
    }
}
