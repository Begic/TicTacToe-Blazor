using TicTacToe.Data.Contracts;
using TicTacToe.Data.Enums;
using TicTacToe.Data.Models;

namespace TicTacToe.Data.Services
{
    public class GameLogic : IGameLogic
    {
        public Player CheckWinner(List<int> pointsPlayerO, List<int> pointsPlayerX)
        {
            if (WinningCombination.Combination.Contains(pointsPlayerX))
            {
                return Player.X;
            }

            if (WinningCombination.Combination.Contains(pointsPlayerO))
            {
                return Player.O;
            }

            return Player.Default;
        }
    }
}