using AutoMapper;
using IntcomTestApp.Application.Filmes.Commands;
using IntcomTestApp.Application.Filmes.Dto;
using IntcomTestApp.Core.Entities;

namespace IntcomTestApp.Application.Filmes.MappingProfiles
{
    public class FilmeMappingProfile : Profile
    {
        public FilmeMappingProfile()
        {
            CreateMap<CreateFilmeCommand, Filme>();
            CreateMap<UpdateFilmeCommand, Filme>();
            CreateMap<Filme, FilmeDto>();
        }
    }
}
