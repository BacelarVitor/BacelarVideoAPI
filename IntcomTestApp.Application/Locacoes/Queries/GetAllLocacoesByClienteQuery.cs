using IntcomTestApp.Application.Locacoes.Dto;
using MediatR;
using System.Collections.Generic;

namespace IntcomTestApp.Application.Locacoes.Queries
{
    public class GetAllLocacoesByClienteQuery : IRequest<List<LocacaoDto>>
    {
        public int ClienteId { get; set; }
    }
}
