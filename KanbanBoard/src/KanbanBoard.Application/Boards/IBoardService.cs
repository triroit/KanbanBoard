using KanbanBoard.Contracts.Boards;

namespace KanbanBoard.Application.Boards
{
    public interface IBoardsService
    {
        Task<Guid> Create(CreateBoardDto createBoardDto, CancellationToken cancellationToken);
    }
}