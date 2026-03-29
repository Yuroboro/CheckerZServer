using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CheckerZ_Server.Models;

namespace CheckerZ_Server.Pages.Games
{
    public class CreateModel : PageModel
    {
        private readonly PlayersContext _context;

        public CreateModel(PlayersContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["PlayerId"] = new SelectList(_context.Player, "Id", "Country");
            return Page();
        }

        [BindProperty]
        public Game Game { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Game.Add(Game);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
