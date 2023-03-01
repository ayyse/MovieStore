using MovieStore.DataContext;

namespace MovieStore.Application.Commands.Delete
{
    public class DeleteDirectorCommand
    {
        public int DirectorID { get; set; }
        private readonly MovieStoreDbContext _context;
        public DeleteDirectorCommand(MovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var director = _context.Directors.SingleOrDefault(x => x.Id == DirectorID);

            if (director is null)
                throw new InvalidOperationException("Yönetmen bulunamadı");

            _context.Directors.Remove(director);
            _context.SaveChanges();
        }
    }
}
