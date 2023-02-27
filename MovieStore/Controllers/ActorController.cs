using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MovieStore.Application.Commands.Create;
using MovieStore.Application.Commands.Delete;
using MovieStore.Application.Commands.Update;
using MovieStore.Application.CommandValidators.Create;
using MovieStore.Application.CommandValidators.Delete;
using MovieStore.Application.CommandValidators.Update;
using MovieStore.Application.Queries.GetAll;
using MovieStore.Application.Queries.GetDetail;
using MovieStore.Application.QueryValidators.GetDetail;
using MovieStore.DataContext;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ActorController : Controller
    {
        private readonly MovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public ActorController(MovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetActors()
        {
            GetActorsQuery query = new GetActorsQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            ActorDetailViewModel result;
            GetActorDetailQuery query = new GetActorDetailQuery(_context, _mapper);
            query.ActorID = id;

            GetActorDetailQueryValidator validator = new GetActorDetailQueryValidator();
            validator.ValidateAndThrow(query);

            result = query.Handle();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddActor([FromBody] CreateActorModel newActor)
        {
            CreateActorCommand command = new CreateActorCommand(_context, _mapper);
            command.Model = newActor;

            CreateActorCommandValidator validator = new CreateActorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateActor(int id, [FromBody] UpdateActorModel updatedActor)
        {
            UpdateActorCommand command = new UpdateActorCommand(_context);
            command.ActorID = id;
            command.Model = updatedActor;

            UpdateActorCommandValidator validator = new UpdateActorCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteActor(int id)
        {
            DeleteActorCommand command = new DeleteActorCommand(_context);
            command.ActorID = id;

            DeleteActorCommandValidator validator = new DeleteActorCommandValidator();
            validator.ValidateAndThrow(command);

            command.Handle();
            return Ok();
        }
    }
}
