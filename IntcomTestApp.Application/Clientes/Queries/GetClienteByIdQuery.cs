using IntcomTestApp.Application.Clientes.Dto;
using MediatR;

namespace IntcomTestApp.Application.Clientes.Queries
{
    public class GetClienteByIdQuery : IRequest<ClienteDto>
    {
        public int Id { get; set; }
    }
}
