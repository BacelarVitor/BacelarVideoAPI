using IntcomTestApp.Application.Locacoes.Dto;
using MediatR;

namespace IntcomTestApp.Application.Locacoes.Queries
{
    public class GetLocacaoByClienteAndFilmeQuery : IRequest<LocacaoDto>
    {
        public int ClienteId { get; set; }
        public int FilmeId { get; set; }
    }
}
