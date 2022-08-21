using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Commands;
using SchoolAPI.Queries;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GroupController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Group>>> GetAllGroups()
        {
            return Ok(await _mediator.Send(new GetAllGroupsQuery()));
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Group>> GetGroup(string groupId)
        {
            var query = new GetGroupByIdQuery(groupId);
            var result = await _mediator.Send(query);
            return (result != null) ? Ok(result) : NotFound();
        }

        [HttpPost]
        public async Task<ActionResult<Group>> AddGroup(Group group)
        {
            var query = new CreateGroupCommand(group);
            var result = await _mediator.Send(query);
            return (result != null) ? Ok(result) : NotFound();
        }

        [HttpPut("{Id},{student}")]
        public async Task<ActionResult<Group>> AddStudentsToGroup(string groupId, List<string> students)
        {
            var query = new AddStudentsToGroupCommand(groupId, students);
            var result = await _mediator.Send(query);
            return (result != null) ? Ok(result) : NotFound();
        }

        [HttpPut]
        public async Task<ActionResult<Group>> UpdateGroup(Group request)
        {
            var query = new UpdateGroupCommand(request);
            var result = await _mediator.Send(query);
            return (result != null) ? Ok(result) : NotFound();
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Group>> DeleteGroup(string Id)
        {
            var query = new DeleteGroupCommand(Id);
            var result = await _mediator.Send(query);
            return (result != null) ? Ok(result) : NotFound();
        }
    }
}
