using Microsoft.EntityFrameworkCore;
using TicTacToe.Data.Contracts;
using TicTacToe.Data.Entities;
using TicTacToe.Data.Enums;
using TicTacToe.Data.Models;

namespace TicTacToe.Data.Providers;

public class HighScoreProvider : IHighScoreProvider
{
    private readonly IDbContextFactory<DataBaseContext> factory;

    public HighScoreProvider(IDbContextFactory<DataBaseContext> factory)
    {
        this.factory = factory;
    }

    public async Task<List<ScoreInfo>> GetAllHighScores()
    {
        await using var db = await factory.CreateDbContextAsync().ConfigureAwait(false);
        return await db.Scores.Select(x => new ScoreInfo
        {
            Id = x.Id,
            Date = x.Date,
            PlayerName = x.PlayerName,
            PlayTime = x.PlayTime
        }).OrderByDescending(x=> x.PlayTime).ToListAsync();
    }

    public async Task SaveHighScore(Player winner, string winnerName)
    {
        await using var db = await factory.CreateDbContextAsync().ConfigureAwait(false);
        await db.Scores.AddAsync(new Score
        {
            PlayerName = winnerName,
            Date = DateTime.Now,
            PlayTime = 88
        });

        await db.SaveChangesAsync();
    }
}