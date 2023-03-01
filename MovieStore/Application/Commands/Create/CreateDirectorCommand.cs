using AutoMapper;
using MovieStore.DataContext;
using MovieStore.Entities;

namespace MovieStore.Application.Commands.Create
{
    public class CreateDirectorCommand
    {
        public CreateDirectorModel Model { get; set; }

        private readonly IMapper _mapper;
        private readonly MovieStoreDbContext _context;
        public CreateDirectorCommand(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Handle()
        {
            var director = _context.Directors.SingleOrDefault(x => x.Name == Model.Name);

            if (director is not null)
                throw new InvalidOperationException("Yönetmen zaten mevcut");

            director = _mapper.Map<Director>(Model);

            _context.Directors.Add(director);
            _context.SaveChanges();
        }
    }

    public class CreateDirectorModel
    {
        public string Name { get; set; }
    }
}
