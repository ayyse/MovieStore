using AutoMapper;
using MovieStore.DataContext;
using MovieStore.Entities;

namespace MovieStore.Application.Commands.Create
{
    public class CreateOrderCommand
    {
        public CreateOrderModel Model { get; set; }

        private readonly IMapper _mapper;
        private readonly MovieStoreDbContext _context;
        public CreateOrderCommand(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var order = _mapper.Map<Order>(Model);

            _context.Orders.Add(order);
            _context.SaveChanges();
        }
    }

    public class CreateOrderModel
    {
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public int MovieId { get; set; }
    }
}
