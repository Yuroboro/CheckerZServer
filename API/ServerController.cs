using CheckerZ_Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace CheckerZ_Server.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        private readonly PlayersContext _context;
        public ServerController(PlayersContext context)
        {
            _context = context;
        }
        [HttpGet("LoginSession/{SessionCode}")]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayersBySession(int code)
        {

            var sessionPlayers = await _context.Player
                .Where(p => p.SessionID == code)
                .ToListAsync();

            if (sessionPlayers == null || sessionPlayers.Count == 0)
            {
                return NotFound("Session Not Found");
            }

     
            foreach (var p in sessionPlayers)
            {
                p.SessionID = 0;
            }

            await _context.SaveChangesAsync();


            return Ok(sessionPlayers);
        }

        [HttpPost("SaveGame")]
        public async Task<ActionResult<Game>> PostGame(Game game)
        {
            _context.Game.Add(game);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}

