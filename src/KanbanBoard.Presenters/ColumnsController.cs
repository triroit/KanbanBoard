using KanbanBoard.Contracts.Columns;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.Presenters
{
    [ApiController]
    [Route("[controller]")]
    public class ColumnsController : ControllerBase
    {
        [HttpDelete("{columnId:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid columnId, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> ChangeOrder([FromBody] ChangeColumnOrderDto changeColumnOrderDto, CancellationToken cancellationToken)
        {
            return Ok();
        }

        [HttpPost("{columnId:guid}/task")]
        public async Task<IActionResult> Add([FromRoute] Guid columnId, [FromBody] AddTaskToColumnDto addTaskToColumnDto, CancellationToken cancellationToken)
        {
            return Ok();
        }
    }
}
