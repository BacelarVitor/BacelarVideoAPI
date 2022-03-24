using MediatR;

namespace IntcomTestApp.Application.Locacoes.Commands
{
    public class DeleteLocacaoCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
