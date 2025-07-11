using KanbanBoard.Domain.Columns;

namespace KanbanBoard.Contracts.Boards
{
    public record AddColumnDto(string Title, int Order, ColumnType ColumnType);
}
