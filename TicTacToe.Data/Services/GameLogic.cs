using TicTacToe.Data.Contracts;
using TicTacToe.Data.Enums;
using TicTacToe.Data.Models;

namespace TicTacToe.Data.Services
{
    public class GameLogic : IGameLogic
    {
        public Player CheckWinner(List<int> pointsPlayerO, List<int> pointsPlayerX)
        {
            if (WinningCombination.Combination.Any(z => z.All(pointsPlayerX.Contains) && z.Count == pointsPlayerX.Count))
            {
                return Player.X;
            }

            if (WinningCombination.Combination.Any(z => z.All(pointsPlayerO.Contains) && z.Count == pointsPlayerO.Count))
            {
                return Player.O;
            }

            return Player.Default;
        }
    }
}