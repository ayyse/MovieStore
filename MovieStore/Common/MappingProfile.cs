using AutoMapper;
using MovieStore.Application.Commands.Create;
using MovieStore.Application.Commands.Update;
using MovieStore.Application.Queries.GetAll;
using MovieStore.Application.Queries.GetDetail;
using MovieStore.Entities;

namespace MovieStore.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Actor, CreateActorModel>().ReverseMap();
            CreateMap<Actor, ActorsViewModel>().ReverseMap();
            CreateMap<Actor, ActorDetailViewModel>().ReverseMap();
            CreateMap<Actor, UpdateActorModel>().ReverseMap();

            CreateMap<Movie, CreateMovieModel>().ReverseMap();
            CreateMap<MoviesViewModel, Movie>().ReverseMap()
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Title))
                .ForMember(dest => dest.Director, opt => opt.MapFrom(src => src.Director.Name));
            CreateMap<MovieDetailViewModel, Movie>().ReverseMap();
            CreateMap<Movie, UpdateMovieModel>().ReverseMap();
        }
    }
}
