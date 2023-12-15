namespace TicTacToe.Data.Models;

public class PlayerInfo
{
    public string NamePlayerOne { get; set; }
    public string NamePlayerTwo { get; set; }
    public string? ColorPlayerOne { get; set; }
    public string? ColorPlayerTwo { get; set; }
    public bool PlayVsHuman { get; set; }
}