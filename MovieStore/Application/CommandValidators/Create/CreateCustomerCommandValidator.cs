using FluentValidation;
using MovieStore.Application.Commands.Create;

namespace MovieStore.Application.CommandValidators.Create
{
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty();
        }
    }
}
