using MovieStore.DataContext;

namespace MovieStore.Application.Commands.Update
{
    public class UpdateActorCommand
    {
        public UpdateActorModel Model { get; set; }
        public int ActorID { get; set; }

        private readonly MovieStoreDbContext _context;
        public UpdateActorCommand(MovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var actor = _context.Actors.SingleOrDefault(x => x.Id == ActorID);

            if (actor is null)
                throw new InvalidOperationException("Oyuncu bulunamadı");

            actor.Name = Model.Name != default ? Model.Name : actor.Name;

            _context.SaveChanges();
        }
    }

    public class UpdateActorModel
    {
        public string Name { get; set; }
    }
}
