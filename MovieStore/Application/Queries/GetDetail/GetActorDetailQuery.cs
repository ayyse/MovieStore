using AutoMapper;
using MovieStore.DataContext;

namespace MovieStore.Application.Queries.GetDetail
{
    public class GetActorDetailQuery
    {
        public int ActorID { get; set; }
        public ActorDetailViewModel Model { get; set; }

        private readonly IMapper _mapper;
        private readonly MovieStoreDbContext _context;
        public GetActorDetailQuery(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ActorDetailViewModel Handle()
        {
            var actor = _context.Actors.SingleOrDefault(x => x.Id == ActorID);

            if (actor is null)
                throw new InvalidOperationException("Oyuncu bulunamadı");

            ActorDetailViewModel vm = _mapper.Map<ActorDetailViewModel>(actor);

            return vm;
        }
    }

    public class ActorDetailViewModel
    {
        public string Name { get; set; }
    }
}
