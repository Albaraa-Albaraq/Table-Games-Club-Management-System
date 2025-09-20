using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using ClubManagementBusinessLayer;

namespace ClubManagementAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    public class VIPBilliardsController : ControllerBase
    {
        private static readonly Dictionary<int, VIP_billiards> _tables = new();

        private VIP_billiards GetTable(int tableId)
        {
            if (!_tables.ContainsKey(tableId))
                _tables[tableId] = new VIP_billiards();
            return _tables[tableId];
        }

        [HttpPost("vip/start", Name = "StartVIP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Start([FromQuery] int tableId, [FromQuery] string playerName)
        {
            var vip = GetTable(tableId);
            return vip.Start(playerName) ? Ok("Game started") : BadRequest("Could not start");
        }

        [HttpPost("vip/end", Name = "EndVIP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult End([FromQuery] int tableId)
        {
            var vip = GetTable(tableId);
            return vip.End() ? Ok("Game ended") : BadRequest("Could not end");
        }

        [HttpGet("vip/time-now", Name = "TimePlayNowVIP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<short> TimePlayNow([FromQuery] int tableId)
        {
            return Ok(GetTable(tableId).TimePlayNow());
        }

        [HttpPost("vip/timer/pause", Name = "PauseVIP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Pause([FromQuery] int tableId)
        {
            GetTable(tableId).PauseTimer();
            return Ok("Timer paused");
        }

        [HttpPost("vip/timer/resume", Name = "ResumeVIP")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Resume([FromQuery] int tableId)
        {
            GetTable(tableId).ResumeTimer();
            return Ok("Timer resumed");
        }

        [HttpGet("vip/fees/hourly", Name = "GetVIPHourlyFees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<float?> GetHourlyFees([FromQuery] int tableId)
        {
            return Ok(GetTable(tableId).GetHourlyFees());
        }

        [HttpPut("vip/fees/hourly", Name = "ChangeVIPHourlyFees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult ChangeHourlyFees([FromQuery] int tableId, [FromQuery] float fee)
        {
            return GetTable(tableId).ChangeHourlyFees(fee)
                ? Ok("Hourly fee changed")
                : BadRequest("Could not change hourly fee");
        }
    }
}
