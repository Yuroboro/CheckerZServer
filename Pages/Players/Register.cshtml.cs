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
        public List<Player> Players { get; set; }


        [BindProperty]
        public int NumPlayers { get; set; } = 1;
        public List<int> PlayerAmountRange = Enumerable.Range(1, 10).ToList();

        public List<string> countries = ["France","Israel","USA","UK","Japan","China","Morroco","Brazil"];

        public IActionResult OnGet()
        {

            Players = new List<Player> { new Player() };

            return Page();
        }


        public IActionResult OnPostRowAmountAsync(int NumPlayers)
        {
            this.NumPlayers = NumPlayers;

            if (Players == null) Players = new List<Player>();

            while (Players.Count < NumPlayers)
            {
                Players.Add(new Player());
            }

            while (Players.Count > NumPlayers)
            {
                Players.RemoveAt(Players.Count - 1);
            }

            ModelState.Clear();
            return Page();
        }


        ////For more information, see https://aka.ms/RazorPagesCRUD.
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
