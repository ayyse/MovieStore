using FluentValidation;
using MovieStore.Application.Commands.Update;

namespace MovieStore.Application.CommandValidators.Update
{
    public class UpdateActorCommandValidator : AbstractValidator<UpdateActorCommand>
    {
        public UpdateActorCommandValidator()
        {
            RuleFor(command => command.ActorID).GreaterThan(0);
            RuleFor(command => command.Model.Name).NotEmpty();
        }
    }
}
