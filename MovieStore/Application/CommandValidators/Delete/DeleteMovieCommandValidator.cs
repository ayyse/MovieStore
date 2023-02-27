using FluentValidation;
using MovieStore.Application.Commands.Delete;

namespace MovieStore.Application.CommandValidators.Delete
{
    public class DeleteMovieCommandValidator : AbstractValidator<DeleteMovieCommand>
    {
        public DeleteMovieCommandValidator()
        {
            RuleFor(command => command.MovieID).GreaterThan(0);
        }
    }
}
