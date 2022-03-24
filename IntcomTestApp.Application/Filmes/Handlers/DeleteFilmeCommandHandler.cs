using IntcomTestApp.Application.Filmes.Commands;
using IntcomTestApp.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Filmes.Handlers
{
    public class DeleteFilmeCommandHandler : IRequestHandler<DeleteFilmeCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteFilmeCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(DeleteFilmeCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Filmes.DeleteAsync(request.Id);
            return result;
        }
    }
}
