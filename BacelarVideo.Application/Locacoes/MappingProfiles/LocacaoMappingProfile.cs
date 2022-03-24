using AutoMapper;
using IntcomTestApp.Application.Locacoes.Commands;
using IntcomTestApp.Application.Locacoes.Dto;
using IntcomTestApp.Core.Entities;

namespace IntcomTestApp.Application.Locacoes.MappingProfiles
{
    public class LocacaoMappingProfile : Profile
    {
        public LocacaoMappingProfile()
        {
            CreateMap<CreateLocacaoCommand, Locacao>();
            CreateMap<UpdateLocacaoCommand, Locacao>();
            CreateMap<Locacao, LocacaoDto>();
        }
    }
}
