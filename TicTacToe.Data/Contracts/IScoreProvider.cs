using TicTacToe.Data.Entities;
using TicTacToe.Data.Models;

namespace TicTacToe.Data.Contracts;

public interface IHighScoreProvider
{
    Task<List<ScoreInfo>> GetAllHighScores();
}