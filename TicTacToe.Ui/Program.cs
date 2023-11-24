using MudBlazor.Services;
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
        builder.Services.AddSingleton<IGameLogic, GameLogic>();


        var app = builder.Build();
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");
        app.Run();
    }
}