using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CheckerZ_Server;

namespace CheckerZ_Server.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly PlayersDB _context;

        public IndexModel(PlayersDB context)
        {
            _context = context;
        }

        public IList<Player> Player { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Player = await _context.Player.ToListAsync();
        }
    }
}
