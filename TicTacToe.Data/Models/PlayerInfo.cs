namespace TicTacToe.Data.Models;

public class PlayerInfo
{
    public string NamePlayerOne { get; set; }
    public string NamePlayerTwo { get; set; }
    public string? ColorPlayerOne { get; set; } = "#000000";
    public string? ColorPlayerTwo { get; set; } = "#000000";
    
    public bool PlayVsHuman { get; set; }
}