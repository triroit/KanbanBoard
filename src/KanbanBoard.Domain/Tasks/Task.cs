namespace KanbanBoard.Domain.Tasks
{
    public class Task
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public Guid ColumnId { get; set; }
        public Guid BoardId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DateToFinish { get; set; }
        public List<Guid> TagIds { get; set; } = [];
        public Guid CreatorId { get; set; }
        public Guid AssignedTo { get; set; }
        public bool IsClosed { get; set; }
    }
}
