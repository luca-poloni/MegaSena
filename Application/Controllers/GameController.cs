using Application.Handles;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/v1/game")]
    public sealed class GameController : ControllerBase
    {
        [HttpPost("play")]
        public ActionResult<IGameResult> Play(List<int> betNumbers)
        {
            var gameHandle = new GameHandle(betNumbers);
            return gameHandle.Handle();
        }
    }
}