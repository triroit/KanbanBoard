namespace KanbanBoard.Domain.Tags
{
    public class Tag
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public Guid BoardId { get; set; }
        public string HexColor { get; set; } = "#FF0000";
    }
}
