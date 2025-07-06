using Microsoft.AspNetCore.Mvc;

namespace KanbanBoard.Presenters
{
    [ApiController]
    [Route("[controller]")]
    public class BoardController : ControllerBase
    {
        [HttpGet]
        public void Get() { }
    }
}
