using TicTacToe.Data.Contracts;
using TicTacToe.Data.Enums;
using TicTacToe.Data.Models;

namespace TicTacToe.Data.Services
{
    public class GameLogic : IGameLogic
    {
        public Player CheckWinner(List<int> pointsPlayerO, List<int> pointsPlayerX)
        {
            if (WinningCombination.Combination.Any(z =>
                    z.All(pointsPlayerX.Contains) && z.Count == pointsPlayerX.Count))
            {
                return Player.X;
            }

            if (WinningCombination.Combination.Any(z =>
                    z.All(pointsPlayerO.Contains) && z.Count == pointsPlayerO.Count))
            {
                return Player.O;
            }

            return Player.Default;
        }
        
        public int GetNextMove(List<int> playerPointsX, List<int> playerPointsO)
        {
            var blockingMove = WinningCombination.Combination
                .Where(c => c.Count(p => playerPointsX.Contains(p)) == 2)
                .SelectMany(c => c)
                .FirstOrDefault(p => !playerPointsX.Contains(p) && !playerPointsO.Contains(p));

            if (blockingMove != 0)
            {
                return blockingMove;
            }

            var availableCombinationsForO = WinningCombination.Combination
                .Where(c => !c.Any(p => playerPointsX.Contains(p)))
                .ToList();

            var bestCombinationForO = availableCombinationsForO
                .OrderByDescending(c => c.Count(p => playerPointsO.Contains(p)))
                .FirstOrDefault();

            if (bestCombinationForO != null)
            {
                var moveForO = bestCombinationForO
                    .Except(playerPointsO)
                    .FirstOrDefault();

                if (moveForO != 0)
                {
                    return moveForO;
                }
            }
            return -1;
        }
    }
}