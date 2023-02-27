using MovieStore.DataContext;

namespace MovieStore.Application.Commands.Delete
{
    public class DeleteActorCommand
    {
        public int ActorID { get; set; }
        private readonly MovieStoreDbContext _context;
        public DeleteActorCommand(MovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var actor = _context.Actors.SingleOrDefault(x => x.Id == ActorID);

            if (actor is null)
                throw new InvalidOperationException("Oyuncu bulunamadı");

            _context.Actors.Remove(actor);
            _context.SaveChanges();
        }
    }
}
