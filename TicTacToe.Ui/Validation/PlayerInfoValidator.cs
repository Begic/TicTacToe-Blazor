using FluentValidation;
using TicTacToe.Data.Models;

namespace TicTacToe.Ui.Validation;

public class PlayerInfoValidator : AbstractValidator<PlayerInfo>
{
    public PlayerInfoValidator()
    {
        RuleFor(x => x.NamePlayerOne).NotEmpty().NotNull();

        When(x => x.PlayVsHuman, () =>
        {
            RuleFor(x => x.NamePlayerTwo).NotEmpty().NotNull();
        });
    }
}