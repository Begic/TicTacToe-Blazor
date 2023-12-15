using TicTacToe.Data.Enums;

namespace TicTacToe.Data.Contracts;

public interface IGameLogic
{
    Player CheckWinner(List<int> pointsPlayerO, List<int> pointsPlayerX);
}