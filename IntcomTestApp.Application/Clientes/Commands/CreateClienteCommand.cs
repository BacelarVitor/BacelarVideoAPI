using MediatR;

namespace IntcomTestApp.Application.Clientes.Commands
{
    public class CreateClienteCommand : IRequest<int>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
