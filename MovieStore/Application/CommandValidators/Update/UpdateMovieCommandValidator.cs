using FluentValidation;
using MovieStore.Application.Commands.Update;

namespace MovieStore.Application.CommandValidators.Update
{
    public class UpdateMovieCommandValidator : AbstractValidator<UpdateMovieCommand>
    {
        public UpdateMovieCommandValidator()
        {
            RuleFor(command => command.MovieID).GreaterThan(0);
            RuleFor(command => command.Model.Name).NotEmpty();
            RuleFor(command => command.Model.Price).NotEmpty();
            RuleFor(command => command.Model.YearOfConstruction.Year).NotEmpty();
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.DirectorId).GreaterThan(0);
        }
    }
}
