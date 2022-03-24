using MediatR;

namespace IntcomTestApp.Application.Locacoes.Commands
{
    public class CreateLocacaoCommand : IRequest<int>
    {
        public int FilmeId { get; set; }
        public int ClienteId { get; set; }
        public bool Ativa { get; set; }
    }
}
