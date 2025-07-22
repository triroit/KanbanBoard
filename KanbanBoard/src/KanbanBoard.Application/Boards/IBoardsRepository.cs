using KanbanBoard.Contracts.Boards;
using KanbanBoard.Domain.Boards;
using KanbanBoard.Domain.Columns;
using KanbanBoard.Domain.Users;

namespace KanbanBoard.Application.Boards
{
    public interface IBoardsRepository
    {
        Task<Guid> AddAsync(Board board, CancellationToken cancellationToken);

        Task<Guid> SaveAsync(Board board, CancellationToken cancellationToken);

        Task<Guid> DeleteAsync(Guid boardId, CancellationToken cancellationToken);

        Task<Board> GetByIdAsync(Guid boardId, CancellationToken cancellationToken);

    }
}
