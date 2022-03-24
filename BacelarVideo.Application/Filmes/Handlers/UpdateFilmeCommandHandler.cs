using AutoMapper;
using IntcomTestApp.Application.Filmes.Commands;
using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Filmes.Handlers
{
    public class UpdateFilmeCommandHandler : IRequestHandler<UpdateFilmeCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateFilmeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateFilmeCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Filmes.UpdateAsync(_mapper.Map<Filme>(request));
            return result;
        }
    }
}
