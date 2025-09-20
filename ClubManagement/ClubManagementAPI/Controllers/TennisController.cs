using ClubManagementBusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ClubManagementAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    public class TennisController : ControllerBase
    {
        private static readonly Dictionary<int, Tennis> _tables = new();

        private Tennis GetTable(int tableId)
        {
            if (!_tables.ContainsKey(tableId))
                _tables[tableId] = new Tennis();
            return _tables[tableId];
        }

        [HttpPost("tennis/start", Name = "StartTennis")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Start([FromQuery] int tableId, [FromQuery] string playerName, [FromQuery] short value = 0)
        {
            var table = GetTable(tableId);
            return table.Start(playerName, value) ? Ok("Game started") : BadRequest("Could not start");
        }

        [HttpPost("tennis/end", Name = "EndTennis")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult End([FromQuery] int tableId)
        {
            var table = GetTable(tableId);
            return table.End() ? Ok("Game ended") : BadRequest("Could not end");
        }

        [HttpPost("tennis/play-once-more", Name = "PlayedOnceMoreTennis")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult PlayedOnceMore([FromQuery] int tableId)
        {
            GetTable(tableId).PlayedOnceMore();
            return Ok("Match count increased");
        }

        [HttpPost("tennis/delete-once", Name = "DeleteOnceTennis")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult PlayedDeleteOnce([FromQuery] int tableId)
        {
            GetTable(tableId).PlayedDleteOnce();
            return Ok("Match count decreased");
        }

        [HttpGet("tennis/times-played", Name = "TimesPlayedTennis")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<short> TimesPlayed([FromQuery] int tableId)
        {
            return Ok(GetTable(tableId).TimesPlay());
        }

        [HttpGet("tennis/fees/match", Name = "GetTennisMatchFees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<float?> GetFeesByMatch([FromQuery] int tableId)
        {
            return Ok(GetTable(tableId).GetFeesbyMatche());
        }

        [HttpPut("tennis/fees/match", Name = "ChangeTennisMatchFees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult ChangeMatchFee([FromQuery] int tableId, [FromQuery] float fee)
        {
            return GetTable(tableId).ChangeMatchFees(fee) ? Ok("Match fee changed") : BadRequest("Could not change match fee");
        }

        [HttpPost("tennis/reset", Name = "ResetTennis")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Reset([FromQuery] int tableId)
        {
            GetTable(tableId).Reset();
            return Ok("Table reset");
        }
    }
}
