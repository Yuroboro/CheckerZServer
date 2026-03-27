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
            
            // 1. שליפת כל השחקנים שמשוייכים לקוד הזה ב-Database
            var sessionPlayers = await _context.Player
                .Where(p => p.SessionID == code)
                .ToListAsync();

            // בדיקה אם הקוד קיים
            if (sessionPlayers == null || sessionPlayers.Count == 0)
            {
                return NotFound("Session Not Found");
            }

            // 2. איפוס הקוד ל-0 לכל השחקנים האלו ב-Database
            // זה הופך את הקוד לחד-פעמי באמת - הוא נמחק מה-DB מיד אחרי השליפה
            foreach (var p in sessionPlayers)
            {
                p.SessionID = 0;
            }

            // שמירת השינויים ב-Database (הקוד נעלם מהטבלה)
            await _context.SaveChangesAsync();

            // 3. שליחת הרשימה ל-WinForms
            // ה-WinForms מקבל את האובייקטים ושומר אותם בזיכרון שלו (ב-SessionManager)
            return Ok(sessionPlayers);
        }
    }
}
