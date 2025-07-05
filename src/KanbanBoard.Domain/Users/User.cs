using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.Domain.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Surname { get; set; }
        public required string Email { get; set; }
        public string? AvatarUrl { get; set; }
        public required string Password { get; set; }
        public List<Guid> UserBoardIds { get; set; } = [];
    }
}
