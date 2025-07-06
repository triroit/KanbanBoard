namespace KanbanBoard.Domain.Columns
{
    public class Column
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public List<Guid> TaskIds { get; set; } = [];
        public Guid BoardId { get; set; }
        public int Order { get; set; }
        public ColumnType ColumnType { get; set; } = ColumnType.Base;
    }
}
