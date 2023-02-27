using FluentValidation;
using MovieStore.Application.Queries.GetDetail;

namespace MovieStore.Application.QueryValidators.GetDetail
{
    public class GetActorDetailQueryValidator : AbstractValidator<GetActorDetailQuery>
    {
        public GetActorDetailQueryValidator()
        {
            RuleFor(query => query.ActorID).GreaterThan(0);
        }
    }
}
