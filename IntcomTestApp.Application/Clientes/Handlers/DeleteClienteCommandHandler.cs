using IntcomTestApp.Application.Clientes.Commands;
using IntcomTestApp.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Clientes.Handlers
{
    public class DeleteClienteCommandHandler : IRequestHandler<DeleteClienteCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteClienteCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Clientes.DeleteAsync(request.Id);
            return result;
        }
    }
}
