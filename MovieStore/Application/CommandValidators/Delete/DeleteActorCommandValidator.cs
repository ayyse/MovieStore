using FluentValidation;
using MovieStore.Application.Commands.Delete;

namespace MovieStore.Application.CommandValidators.Delete
{
    public class DeleteActorCommandValidator : AbstractValidator<DeleteActorCommand>
    {
        public DeleteActorCommandValidator()
        {
            RuleFor(command => command.ActorID).GreaterThan(0);
        }
    }
}
