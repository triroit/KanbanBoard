using FluentValidation;
using KanbanBoard.Contracts.Boards;
using KanbanBoard.Domain.Boards;
using Microsoft.Extensions.Logging;

namespace KanbanBoard.Application.Boards
{
    public class BoardsService : IBoardsService
    {
        private readonly IBoardsRepository _boardsRepository;
        private readonly IValidator<CreateBoardDto> _validator;
        private readonly ILogger<BoardsService> _logger;

        public BoardsService(IBoardsRepository boardsRepository,
            IValidator<CreateBoardDto> validator,
            ILogger<BoardsService> logger)
        {
            _boardsRepository = boardsRepository;
            _validator = validator;
            _logger = logger;
        }

        public async Task<Guid> Create(CreateBoardDto createBoardDto, CancellationToken cancellationToken)
        {
            // input validation
            var validationResult = await _validator.ValidateAsync(createBoardDto, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            // buisness validation

            // create entity
            Guid boardId = Guid.NewGuid();

            var board = new Board()
            {
                Id = boardId,
                Title = createBoardDto.Title,
                CreatorId = createBoardDto.CreatorId,
            };

            // save entity to db
            await _boardsRepository.AddAsync(board, cancellationToken);

            // log
            _logger.LogInformation("Board created with ID {boardId}", boardId);

            return boardId;
        }

        public async Task Add(Guid boardId, AddColumnDto addColumnDto, CancellationToken cancellationToken)
        {
        }

        public async Task Add(Guid boardId, Guid userToAdd, CancellationToken cancellationToken)
        {
        }

        public async Task Delete(Guid boardId, CancellationToken cancellationToken)
        {
        }

        public async Task GetById(Guid boardId, CancellationToken cancellationToken)
        {
        }

        public async Task Get(Guid userID, CancellationToken cancellationToken)
        {
        }
    }
}
