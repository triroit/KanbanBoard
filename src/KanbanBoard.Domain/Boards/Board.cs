namespace KanbanBoard.Domain.Boards
{
    public class Board
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public Guid CreatorId { get; set; }
        public List<Guid> TagIds { get; set; } = [];
        public List<Guid> ColumnIds { get; set; } = [];
        public List<Guid> UserIds { get; set; } = [];

    }
}
