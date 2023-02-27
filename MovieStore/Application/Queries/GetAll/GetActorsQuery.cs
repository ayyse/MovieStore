using AutoMapper;
using MovieStore.DataContext;

namespace MovieStore.Application.Queries.GetAll
{
    public class GetActorsQuery
    {
        private readonly MovieStoreDbContext _context;
        private readonly IMapper _mapper;
        
        public GetActorsQuery(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ActorsViewModel> Handle()
        {
            var actors = _context.Actors.OrderBy(x => x.Id);
            var vm = _mapper.Map<List<ActorsViewModel>>(actors);
            return vm;
        }
    }

    public class ActorsViewModel
    {
        public string Name { get; set; }
    }
}
