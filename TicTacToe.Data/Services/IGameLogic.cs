using TicTacToe.Data.Enums;

namespace TicTacToe.Data.Services;

public interface IGameLogic
{
    Player CheckWinner(List<int> pointsPlayerO, List<int> pointsPlayerX);
}