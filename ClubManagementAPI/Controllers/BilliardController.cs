using ClubManagementBusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace ClubManagementAPI.Controllers
{
    [ApiController]
    [Route("api/")]
    public class BilliardController : ControllerBase
    {
        private static readonly Dictionary<int, Billiard> _tables = new();

        private Billiard GetBilliard(int tableId)
        {
            if (!_tables.ContainsKey(tableId))
                _tables[tableId] = new Billiard();
            return _tables[tableId];
        }

        [HttpPost("billiard/start", Name = "StartBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Start([FromQuery] int tableId, [FromQuery] string playerName, [FromQuery] short value = 0)
        {
            var billiard = GetBilliard(tableId);
            return billiard.Start(playerName, value) ? Ok("Game started") : BadRequest("Could not start");
        }

        [HttpPost("billiard/end", Name = "EndBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult End([FromQuery] int tableId)
        {
            var billiard = GetBilliard(tableId);
            return billiard.End() ? Ok("Game ended") : BadRequest("Could not end");
        }

        [HttpPost("billiard/play-once-more", Name = "PlayedOnceMoreBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult PlayedOnceMore([FromQuery] int tableId)
        {
            GetBilliard(tableId).PlayedOnceMore();
            return Ok("Match count increased");
        }

        [HttpPost("billiard/delete-once", Name = "DeleteOnceBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult PlayedDeleteOnce([FromQuery] int tableId)
        {
            GetBilliard(tableId).PlayedDleteOnce();
            return Ok("Match count decreased");
        }

        [HttpPost("billiard/fees/hourly", Name = "SetFeesByHourBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult SetFeesByHour([FromQuery] int tableId)
        {
            GetBilliard(tableId).SetFeesbyHour();
            return Ok("Set to hourly fees");
        }

        [HttpPost("billiard/fees/match", Name = "SetFeesByMatchBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult SetFeesByMatch([FromQuery] int tableId)
        {
            GetBilliard(tableId).SetFeesbyMatche();
            return Ok("Set to match fees");
        }

        [HttpGet("billiard/fees/hourly", Name = "GetFeesByHourBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<float?> GetFeesByHour([FromQuery] int tableId)
        {
            return Ok(GetBilliard(tableId).GetFeesbyHour());
        }

        [HttpGet("billiard/fees/match", Name = "GetFeesByMatchBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<float?> GetFeesByMatch([FromQuery] int tableId)
        {
            return Ok(GetBilliard(tableId).GetFeesbyMatche());
        }

        [HttpGet("billiard/fees", Name = "GetAllFeesBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<object> GetAllFees([FromQuery] int tableId)
        {
            var fees = GetBilliard(tableId).GetFees();
            return Ok(new { Hourly = fees.Item1, Match = fees.Item2 });
        }

        [HttpPut("billiard/fees/hourly", Name = "ChangeHourlyFeeBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult ChangeHourlyFee([FromQuery] int tableId, [FromQuery] float fee)
        {
            return GetBilliard(tableId).ChangeHourlyFees(fee) ? Ok("Hourly fee changed") : BadRequest("Could not change hourly fee");
        }

        [HttpPut("billiard/fees/match", Name = "ChangeMatchFeeBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult ChangeMatchFee([FromQuery] int tableId, [FromQuery] float fee)
        {
            return GetBilliard(tableId).ChangeMatchFees(fee) ? Ok("Match fee changed") : BadRequest("Could not change match fee");
        }

        [HttpPut("billiard/fees/all", Name = "ChangeAllFeesBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult ChangeAllFees([FromQuery] int tableId, [FromQuery] float hourly, [FromQuery] float match)
        {
            return GetBilliard(tableId).ChangeAllFees(hourly, match) ? Ok("All fees updated") : BadRequest("Could not update fees");
        }

        [HttpPost("billiard/save-matches", Name = "SaveMatchesBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult SaveMatches([FromQuery] int tableId, [FromQuery] short matches)
        {
            return GetBilliard(tableId).SaveMatchs(matches) ? Ok("Matches saved") : BadRequest("Could not save matches");
        }

        [HttpPost("billiard/timer/pause", Name = "PauseTimerBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult PauseTimer([FromQuery] int tableId)
        {
            GetBilliard(tableId).PauseTimer();
            return Ok("Timer paused");
        }

        [HttpPost("billiard/timer/resume", Name = "ResumeTimerBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult ResumeTimer([FromQuery] int tableId)
        {
            GetBilliard(tableId).ResumeTimer();
            return Ok("Timer resumed");
        }

        [HttpGet("billiard/times-played", Name = "TimesPlayedBilliard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<short> TimesPlayed([FromQuery] int tableId)
        {
            return Ok(GetBilliard(tableId).TimesPlay());
        }
    }
}
