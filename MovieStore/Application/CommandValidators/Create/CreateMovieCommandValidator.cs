using FluentValidation;
using MovieStore.Application.Commands.Create;

namespace MovieStore.Application.CommandValidators.Create
{
    public class CreateMovieCommandValidator : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty();
            RuleFor(command => command.Model.Price).NotEmpty();
            RuleFor(command => command.Model.YearOfConstruction.Year).NotEmpty();
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.DirectorId).GreaterThan(0);
        }
    }
}
