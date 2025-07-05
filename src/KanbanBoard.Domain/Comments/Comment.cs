namespace KanbanBoard.Domain.Comments
{
    public class Comment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public required string CommentText { get; set; }
        public Guid TaskId { get; set; }
        public Guid? ParentId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
