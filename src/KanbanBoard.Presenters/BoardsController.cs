using KanbanBoard.Application.Boards;
using KanbanBoard.Contracts.Boards;
using Microsoft.AspNetCore.Mvc;

namespace KanbanBoard.Presenters
{
    [ApiController]
    [Route("[controller]")]
    public class BoardsController : ControllerBase
    {
        private readonly IBoardsService _boardsService;

        public BoardsController(IBoardsService boardsService)
        {
            _boardsService = boardsService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBoardDto createBoardDto, CancellationToken cancellationToken)
        {
            var boardId = await _boardsService.Create(createBoardDto, cancellationToken);
            return Ok(boardId);
        }

        [HttpPut("{boardId:guid}/column")]
        public async Task<IActionResult> Add([FromRoute] Guid boardId, [FromBody] AddColumnDto addColumnDto, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpPut("{boardId:guid}")]
        public async Task<IActionResult> Add([FromRoute] Guid boardId, [FromQuery] Guid userToAdd, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpDelete("{boardId:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid boardId, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpGet("{boardId:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid boardId, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpGet("{userId:guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid userID, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
