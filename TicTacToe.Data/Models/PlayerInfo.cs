namespace TicTacToe.Data.Models;

public class PlayerInfo
{
    public string NamePlayerOne { get; set; }
    public string NamePlayerTwo { get; set; }
    public string? ColorPlayerOne { get; set; } = "#ff0000";
    public string? ColorPlayerTwo { get; set; } = "#ff0000";
    
    public bool PlayVsHuman { get; set; }
}