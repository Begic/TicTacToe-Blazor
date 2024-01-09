using TicTacToe.Data.Enums;
using TicTacToe.Data.Models;

namespace TicTacToe.Data.Contracts;

public interface IHighScoreProvider
{
    Task<List<ScoreInfo>> GetAllHighScores();
    Task SaveHighScore(Player winner, string winnerName);
}