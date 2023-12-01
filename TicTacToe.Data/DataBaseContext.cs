using Microsoft.EntityFrameworkCore;
using TicTacToe.Data.Entities;

namespace TicTacToe.Data;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }

    public DbSet<Score> Scores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(@"DataSource=MyDataBase.db;");
    }
}