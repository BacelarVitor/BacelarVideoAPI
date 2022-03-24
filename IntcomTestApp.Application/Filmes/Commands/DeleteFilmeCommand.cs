using MediatR;

namespace IntcomTestApp.Application.Filmes.Commands
{
    public class DeleteFilmeCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
