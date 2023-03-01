using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieStore.DataContext;

namespace MovieStore.Application.Queries.GetDetail
{
    public class GetMovieDetailQuery
    {
        public int MovieID { get; set; }
        public MovieDetailViewModel Model { get; set; }

        private readonly IMapper _mapper;
        private readonly MovieStoreDbContext _context;
        public GetMovieDetailQuery(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public MovieDetailViewModel Handle()
        {
            var movie = _context.Movies.Where(x => x.IsDeleted == false).Include(x => x.Genre).Include(x => x.Director).SingleOrDefault(x => x.Id == MovieID);

            if (movie is null)
                throw new InvalidOperationException("Film bulunamadı");

            MovieDetailViewModel vm = _mapper.Map<MovieDetailViewModel>(movie);

            return vm;
        }
    }

    public class MovieDetailViewModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime YearOfConstruction { get; set; }

        public string Genre { get; set; }
        public string Director { get; set; }
    }
}
