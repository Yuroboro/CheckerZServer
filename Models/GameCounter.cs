using System.ComponentModel.DataAnnotations;

namespace CheckerZ_Server.Models
{
    public class GameCounter
    {
        public string Name { get; set; }
        [Display(Name = "Game Amount")]
        public int Amount {  get; set; }
    }
}
