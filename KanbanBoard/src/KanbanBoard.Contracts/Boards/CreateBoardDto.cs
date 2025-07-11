namespace KanbanBoard.Contracts.Boards
{
    public record CreateBoardDto(string Title, Guid CreatorId);
}
