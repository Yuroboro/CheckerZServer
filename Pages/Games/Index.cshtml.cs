using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CheckerZ_Server.Models;

namespace CheckerZ_Server.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _context;

        public IndexModel(DataContext context)
        {
            _context = context;
        } 

        public IList<Game> Games { get; set; } = default!;
        public async Task OnGetAsync()
        {
            Games = await _context.Game
                .Include(g => g.Player).Where(g=>g.GameDate!=null).ToListAsync();
        }

        //querie 24
        public async Task OnPostShowGameData()
        {
            var games = await _context.Game.ToListAsync();
        }
    }
}
