using FluentValidation;
using KanbanBoard.Contracts.Boards;

namespace KanbanBoard.Application.Boards
{
    public class CreateBoardValidator : AbstractValidator<CreateBoardDto>
    {
        public CreateBoardValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title can't be empty");
        }
    }
}
