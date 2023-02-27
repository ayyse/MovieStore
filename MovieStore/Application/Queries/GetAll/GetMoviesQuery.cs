using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieStore.DataContext;
using MovieStore.Entities;

namespace MovieStore.Application.Queries.GetAll
{
    public class GetMoviesQuery
    {
        private readonly MovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetMoviesQuery(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MoviesViewModel> Handle()
        {
            var movies = _context.Movies.Include(x => x.Genre).Include(x => x.Director).OrderBy(x => x.Id);
            var vm = _mapper.Map<List<MoviesViewModel>>(movies);
            return vm;
        }
    }

    public class MoviesViewModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime YearOfConstruction { get; set; }

        public string Genre { get; set; }
        public string Director { get; set; }
    }
}
