using AutoMapper;
using MovieStore.DataContext;
using MovieStore.Entities;

namespace MovieStore.Application.Commands.Create
{
    public class CreateCustomerCommand
    {
        public CreateCustomerModel Model { get; set; }

        private readonly IMapper _mapper;
        private readonly MovieStoreDbContext _context;
        public CreateCustomerCommand(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Name == Model.Name);

            if (customer is not null)
                throw new InvalidOperationException("Müşteri zaten mevcut");

            customer = _mapper.Map<Customer>(Model);

            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
    }

    public class CreateCustomerModel
    {
        public string Name { get; set; }
    }
}
