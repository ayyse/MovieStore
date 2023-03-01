using AutoMapper;
using MovieStore.DataContext;

namespace MovieStore.Application.Queries.GetAll
{
    public class GetCustomersQuery
    {
        private readonly MovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomersQuery(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<CustomersViewModel> Handle()
        {
            var customers = _context.Actors.OrderBy(x => x.Id);
            var vm = _mapper.Map<List<CustomersViewModel>>(customers);
            return vm;
        }
    }

    public class CustomersViewModel
    {
        public string Name { get; set; }
    }
}
