using CheckerZ_Server.Objects;

namespace CheckerZ_Server.API
{
    public class GameStateRequest
    {
        public List<BoardLocation> PlayerLocations { get; set; }
        public List<BoardLocation> ComputerLocations { get; set; }
    }
}
