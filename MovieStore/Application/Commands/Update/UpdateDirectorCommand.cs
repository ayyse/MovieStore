using MovieStore.DataContext;

namespace MovieStore.Application.Commands.Update
{
    public class UpdateDirectorCommand
    {
        public UpdateDirectorModel Model { get; set; }
        public int DirectorID { get; set; }

        private readonly MovieStoreDbContext _context;
        public UpdateDirectorCommand(MovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            var director = _context.Directors.SingleOrDefault(x => x.Id == DirectorID);

            if (director is null)
                throw new InvalidOperationException("Yönetmen bulunamadı");

            director.Name = Model.Name != default ? Model.Name : director.Name;

            _context.SaveChanges();
        }
    }

    public class UpdateDirectorModel
    {
        public string Name { get; set; }
    }
}
