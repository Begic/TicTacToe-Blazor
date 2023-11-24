namespace TicTacToe.Data.Entities;

public class Score
{
    public int Id { get; set; }
    public string PlayerName { get; set; }
    public DateTime Date { get; set; }
    public double PlayTime { get; set; }
}