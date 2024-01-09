namespace TicTacToe.Data.Services;

public class UserService
{
    public CurrentPlayer? CurrentPlayers { get; set; }

    public bool HasValue()
    {
        if (string.IsNullOrEmpty(CurrentPlayers.NamePlayerOne))
        {
            return false;
        }

        return true;
    }
}