using FluentValidation;
using MovieStore.Application.Commands.Delete;

namespace MovieStore.Application.CommandValidators.Delete
{
    public class DeleteCustomerCommandValidator : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidator()
        {
            RuleFor(command => command.CustomerID).GreaterThan(0);
        }
    }
}
