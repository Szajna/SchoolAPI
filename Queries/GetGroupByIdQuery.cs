using MediatR;

namespace SchoolAPI.Queries
{
    public class GetGroupByIdQuery : IRequest<Group>
    {
        public string Id { get; }

        public GetGroupByIdQuery(string id)
        {
            Id = id;
        }
    }
}
