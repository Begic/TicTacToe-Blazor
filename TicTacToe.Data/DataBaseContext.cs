using Microsoft.EntityFrameworkCore;
using TicTacToe.Data.Entities;

namespace TicTacToe.Data;

public class DataBaseContext : DbContext
{
    public DbSet<Score> Scores { get; set; }
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(@"DataSource=MyDataBase.db;");
    }
}