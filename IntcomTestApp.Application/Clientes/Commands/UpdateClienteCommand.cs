using MediatR;

namespace IntcomTestApp.Application.Clientes.Commands
{
    public class UpdateClienteCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
