using MovieStore.DataContext;

namespace MovieStore.Application.Commands.Update
{
    public class UpdateMovieCommand
    {
        public UpdateMovieModel Model { get; set; }
        public int MovieID { get; set; }

        private readonly MovieStoreDbContext _context;
        public UpdateMovieCommand(MovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var movie = _context.Actors.SingleOrDefault(x => x.Id == MovieID);

            if (movie is null)
                throw new InvalidOperationException("Film bulunamadı");

            movie.Name = Model.Name != default ? Model.Name : movie.Name;

            _context.SaveChanges();
        }
    }

    public class UpdateMovieModel
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime YearOfConstruction { get; set; }

        public int GenreId { get; set; }
        public int DirectorId { get; set; }
    }
}
