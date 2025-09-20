using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using ClubManagementBusinessLayer;

namespace ClubManagementAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    public class FoosballController : ControllerBase
    {
        private static readonly Dictionary<int, Foosball> _tables = new();

        private Foosball GetTable(int tableId)
        {
            if (!_tables.ContainsKey(tableId))
                _tables[tableId] = new Foosball();
            return _tables[tableId];
        }

        [HttpPost("foosball/start", Name = "StartFoosball")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Start([FromQuery] int tableId, [FromQuery] string playerName, [FromQuery] short value = 0)
        {
            var table = GetTable(tableId);
            return table.Start(playerName, value) ? Ok("Game started") : BadRequest("Could not start");
        }

        [HttpPost("foosball/end", Name = "EndFoosball")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult End([FromQuery] int tableId)
        {
            var table = GetTable(tableId);
            return table.End() ? Ok("Game ended") : BadRequest("Could not end");
        }

        [HttpPost("foosball/play-once-more", Name = "PlayedOnceMoreFoosball")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult PlayedOnceMore([FromQuery] int tableId)
        {
            GetTable(tableId).PlayedOnceMore();
            return Ok("Match count increased");
        }

        [HttpPost("foosball/delete-once", Name = "DeleteOnceFoosball")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult PlayedDeleteOnce([FromQuery] int tableId)
        {
            GetTable(tableId).PlayedDleteOnce();
            return Ok("Match count decreased");
        }

        [HttpGet("foosball/times-played", Name = "TimesPlayedFoosball")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<short> TimesPlayed([FromQuery] int tableId)
        {
            return Ok(GetTable(tableId).TimesPlay());
        }

        [HttpGet("foosball/fees/match", Name = "GetFoosballMatchFees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<float?> GetFeesByMatch([FromQuery] int tableId)
        {
            return Ok(GetTable(tableId).GetFeesbyMatche());
        }

        [HttpPut("foosball/fees/match", Name = "ChangeFoosballMatchFees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult ChangeMatchFee([FromQuery] int tableId, [FromQuery] float fee)
        {
            return GetTable(tableId).ChangeMatchFees(fee) ? Ok("Match fee changed") : BadRequest("Could not change match fee");
        }
    }
}

