using AutoMapper;
using IntcomTestApp.Application.Clientes.Commands;
using IntcomTestApp.Application.Clientes.Dto;
using IntcomTestApp.Core.Entities;

namespace IntcomTestApp.Application.Clientes.MappingProfiles
{
    public class ClienteMappingProfile : Profile
    {
        public ClienteMappingProfile()
        {
            CreateMap<CreateClienteCommand, Cliente>();
            CreateMap<UpdateClienteCommand, Cliente>();
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
