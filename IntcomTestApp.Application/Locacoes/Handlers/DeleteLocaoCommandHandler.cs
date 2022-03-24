using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Application.Locacoes.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Locacoes.Handlers
{
    public class DeleteLocaoCommandHandler : IRequestHandler<DeleteLocacaoCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteLocaoCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteLocacaoCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Locacoes.DeleteAsync(request.Id);
            return result;
        }
    }
}
