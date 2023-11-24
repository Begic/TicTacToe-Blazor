using Microsoft.EntityFrameworkCore;

namespace TicTacToe.Data;

public class DataBaseContext : DbContext
{
    
    
    
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(@"DataSource=MyDataBase.db;");
    }
}