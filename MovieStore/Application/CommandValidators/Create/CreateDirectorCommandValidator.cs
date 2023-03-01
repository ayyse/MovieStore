using FluentValidation;
using MovieStore.Application.Commands.Create;

namespace MovieStore.Application.CommandValidators.Create
{
    public class CreateDirectorCommandValidator : AbstractValidator<CreateDirectorCommand>
    {
        public CreateDirectorCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty();
        }
    }
}
