using FluentValidation;
using MovieStore.Application.Commands.Create;

namespace MovieStore.Application.CommandValidators.Create
{
    public class CreateActorCommandValidator : AbstractValidator<CreateActorCommand>
    {
        public CreateActorCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty();
        }
    }
}
