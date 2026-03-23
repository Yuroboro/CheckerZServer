using CheckerZ_Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CheckerZ_Server.Pages.Players
{
    public class LoginModel : PageModel
    {
        private readonly PlayersContext _context;
        public LoginModel(PlayersContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Player> Players { get; set; }


        [BindProperty]
        // current rows for register players
        public int NumPlayers { get; set; } = 1;
        // range for number of players chosen
        public List<int> PlayerAmountRange = Enumerable.Range(1, 10).ToList();

        public IActionResult OnGet()
        {

            Players = new List<Player> { new Player() };

            return Page();
        }

        public IActionResult OnPostRowAmountAsync(int NumPlayers)
        {
            this.NumPlayers = NumPlayers;

            // if players list is empty then initialize players list

            if (Players == null) Players = new List<Player>();

            //when extending player number add more rows
            while (Players.Count < NumPlayers)
            {
                Players.Add(new Player());
            }
            // when reducing player number remove rows 

            while (Players.Count > NumPlayers)
            {
                Players.RemoveAt(Players.Count - 1);
            }

            //overrides and updates the page

            ModelState.Clear();
            return Page();
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    for (int i = 0; i < NumPlayers; i++)
        //    {
        //        var exists = await _context.Player.AnyAsync(p => p.Id == Players[i].Id);

        //    }
        //    await _context.SaveChangesAsync();
        //    return RedirectToPage("/UserLogin");
        //}

    }
}
