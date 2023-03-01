using FluentValidation;
using MovieStore.Application.Commands.Update;

namespace MovieStore.Application.CommandValidators.Update
{
    public class UpdateDirectorCommandValidator : AbstractValidator<UpdateDirectorCommand>
    {
        public UpdateDirectorCommandValidator()
        {
            RuleFor(command => command.DirectorID).GreaterThan(0);
            RuleFor(command => command.Model.Name).NotEmpty();
        }
    }
}
