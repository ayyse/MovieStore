using MovieStore.DataContext;

namespace MovieStore.Application.Commands.Delete
{
    public class DeleteCustomerCommand
    {
        public int CustomerID { get; set; }
        private readonly MovieStoreDbContext _context;
        public DeleteCustomerCommand(MovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == CustomerID);

            if (customer is null)
                throw new InvalidOperationException("Müşteri bulunamadı");

            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
