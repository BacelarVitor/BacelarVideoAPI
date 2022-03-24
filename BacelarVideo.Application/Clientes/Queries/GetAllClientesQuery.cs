using IntcomTestApp.Application.Clientes.Dto;
using MediatR;
using System.Collections.Generic;

namespace IntcomTestApp.Application.Clientes.Queries
{
    public class GetAllClientesQuery : IRequest<List<ClienteDto>>
    {
    }
}
