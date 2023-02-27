using FluentValidation;
using MovieStore.Application.Queries.GetDetail;

namespace MovieStore.Application.QueryValidators.GetDetail
{
    public class GetMovieDetailQueryValidator : AbstractValidator<GetMovieDetailQuery>
    {
        public GetMovieDetailQueryValidator()
        {
            RuleFor(query => query.MovieID).GreaterThan(0);
        }
    }
}
