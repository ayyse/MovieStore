using FluentValidation;
using MovieStore.Application.Commands.Delete;

namespace MovieStore.Application.CommandValidators.Delete
{
    public class DeleteDirectorCommandValidator : AbstractValidator<DeleteDirectorCommand>
    {
        public DeleteDirectorCommandValidator()
        {
            RuleFor(command => command.DirectorID).GreaterThan(0);
        }
    }
}
