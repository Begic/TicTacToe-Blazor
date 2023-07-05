namespace TicTacToe.Data.Services;

public interface IGameLogic
{
    string CheckWinner(List<int> pointsPlayerO, List<int> pointsPlayerX);
}