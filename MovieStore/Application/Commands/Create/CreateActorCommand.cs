using AutoMapper;
using MovieStore.DataContext;
using MovieStore.Entities;

namespace MovieStore.Application.Commands.Create
{
    public class CreateActorCommand
    {
        public CreateActorModel Model { get; set; }

        private readonly IMapper _mapper;
        private readonly MovieStoreDbContext _context;
        public CreateActorCommand(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var actor = _context.Actors.SingleOrDefault(x => x.Name == Model.Name);

            if (actor is not null)
                throw new InvalidOperationException("Oyuncu zaten mevcut");

            actor = _mapper.Map<Actor>(Model);

            _context.Actors.Add(actor);
            _context.SaveChanges();
        }
    }

    public class CreateActorModel
    {
        public string Name { get; set; }
    }
}
