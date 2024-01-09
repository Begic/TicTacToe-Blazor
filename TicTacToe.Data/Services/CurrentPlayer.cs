namespace TicTacToe.Data.Services;

public class CurrentPlayer
{
    public bool PlayVsHuman { get; set; }

    public string NamePlayerOne { get; set; }
    public string NamePlayerTwo { get; set; }
    public string? ColorPlayerOne { get; set; } 
    public string? ColorPlayerTwo { get; set; } 
}