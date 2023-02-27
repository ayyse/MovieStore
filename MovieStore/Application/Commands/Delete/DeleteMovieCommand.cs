using MovieStore.DataContext;

namespace MovieStore.Application.Commands.Delete
{
    public class DeleteMovieCommand
    {
        public int MovieID { get; set; }
        private readonly MovieStoreDbContext _context;
        public DeleteMovieCommand(MovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var movie = _context.Movies.SingleOrDefault(x => x.Id == MovieID);

            if (movie is null)
                throw new InvalidOperationException("Film bulunamadı");

            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
    }
}
