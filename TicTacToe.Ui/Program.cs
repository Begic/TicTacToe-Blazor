using Microsoft.EntityFrameworkCore;
using MudBlazor;
using MudBlazor.Services;
using TicTacToe.Data;
using TicTacToe.Data.Services;

namespace TicTacToe.Ui;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddMudServices();
        builder.Services.AddMudServices(
            conf => conf.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight);
        
        builder.Services.AddSingleton<IGameLogic, GameLogic>();
        
        builder.Services.AddDbContextFactory<DataBaseContext>(options =>
            options.UseSqlite(@"DataSource=MyDataBase.db;"));
        
        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        using (var db = scope.ServiceProvider.GetService<IDbContextFactory<DataBaseContext>>().CreateDbContext())
        {
            db.Database.Migrate();
        }

        if (!app.Environment.IsDevelopment()) app.UseExceptionHandler("/Error");

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");
        app.Run();
    }
}