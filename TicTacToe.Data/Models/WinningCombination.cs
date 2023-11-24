namespace TicTacToe.Data.Models;

public static class WinningCombination
{
    static WinningCombination()
    {
        Combination.AddRange(new List<List<int>>
        {
            new() { 1, 2, 3 },
            new() { 4, 5, 6 },
            new() { 7, 8, 9 },
            new() { 1, 4, 7 },
            new() { 2, 5, 8 },
            new() { 3, 6, 9 },
            new() { 1, 5, 9 },
            new() { 3, 5, 7 }
        });
    }

    public static List<List<int>> Combination { get; set; } = new();
}