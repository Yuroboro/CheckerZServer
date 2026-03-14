using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CheckerZ_Server;

namespace CheckerZ_Server.Pages.Players
{
    public class RegisterModel : PageModel
    {
        private readonly PlayersDB _context;

        public RegisterModel(PlayersDB context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Player> Players { get; set; } = default!;

        [BindProperty]
        public int NumPlayers { get; set; }

        public List<string> countries = ["France","Israel","USA","UK","Japan","China","Morroco","Brazil"]; 

        //public IActionResult OnGet()
        //{
        //    return Page();
        //}



        // For more information, see https://aka.ms/RazorPagesCRUD.
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Player.Add(Player);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./Index");
        //}
    }
}
