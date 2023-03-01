using AutoMapper;
using MovieStore.DataContext;

namespace MovieStore.Application.Queries.GetAll
{
    public class GetDirectorsQuery
    {
        private readonly MovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetDirectorsQuery(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<DirectorsViewModel> Handle()
        {
            var directors = _context.Directors.OrderBy(x => x.Id);
            var vm = _mapper.Map<List<DirectorsViewModel>>(directors);
            return vm;
        }
    }

    public class DirectorsViewModel
    {
        public string Name { get; set; }
    }
}
