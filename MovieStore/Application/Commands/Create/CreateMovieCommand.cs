using AutoMapper;
using MovieStore.DataContext;
using MovieStore.Entities;

namespace MovieStore.Application.Commands.Create
{
    public class CreateMovieCommand
    {
        public CreateMovieModel Model { get; set; }

        private readonly IMapper _mapper;
        private readonly MovieStoreDbContext _context;
        public CreateMovieCommand(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var movie = _context.Movies.SingleOrDefault(x => x.Name == Model.Name);

            if (movie is not null)
                throw new InvalidOperationException("Film zaten mevcut");

            movie = _mapper.Map<Movie>(Model);

            _context.Movies.Add(movie);
            _context.SaveChanges();
        }
    }

    public class CreateMovieModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime YearOfConstruction { get; set; }

        public int GenreId { get; set; }
        public int DirectorId { get; set; }
    }
}
