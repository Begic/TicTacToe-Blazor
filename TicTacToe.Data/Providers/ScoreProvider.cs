using Microsoft.EntityFrameworkCore;
using TicTacToe.Data.Contracts;

namespace TicTacToe.Data.Providers;

public class ScoreProvider :  IScoreProvider
{
    private readonly IDbContextFactory<DataBaseContext> factory;

    public ScoreProvider(IDbContextFactory<DataBaseContext> factory)
    {
        this.factory = factory;
    }
    
    
}