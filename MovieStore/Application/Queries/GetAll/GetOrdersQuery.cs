using AutoMapper;
using MovieStore.DataContext;

namespace MovieStore.Application.Queries.GetAll
{
    public class GetOrdersQuery
    {
        private readonly MovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetOrdersQuery(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<OrdersViewModel> Handle()
        {
            var orders = _context.Orders.OrderBy(x => x.Id);
            var vm = _mapper.Map<List<OrdersViewModel>>(orders);
            return vm;
        }
    }

    public class OrdersViewModel
    {
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public string Customer { get; set; } 
    }
}
