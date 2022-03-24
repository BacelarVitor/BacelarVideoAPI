using MediatR;

namespace IntcomTestApp.Application.Clientes.Commands
{
    public class DeleteClienteCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
