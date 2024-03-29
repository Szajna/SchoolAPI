﻿using MediatR;

namespace SchoolAPI.Commands
{
    public class AddStudentsToGroupCommand : IRequest<Group>
    {
        public string GroupId { get; }
        public string StudentId { get; }

        public AddStudentsToGroupCommand(string groupId, string studentId)
        {
            GroupId = groupId;
            StudentId = studentId;
        }
    }
}
