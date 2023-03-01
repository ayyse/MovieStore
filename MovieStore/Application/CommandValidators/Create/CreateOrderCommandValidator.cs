using FluentValidation;
using MovieStore.Application.Commands.Create;

namespace MovieStore.Application.CommandValidators.Create
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(command => command.Model.TotalPrice).NotEmpty();
            RuleFor(command => command.Model.OrderDate.Year).NotEmpty();
            RuleFor(command => command.Model.CustomerId).GreaterThan(0);
            RuleFor(command => command.Model.MovieId).GreaterThan(0);
        }
    }
}
