using AutoMapper;
using IntcomTestApp.Application.Filmes.Commands;
using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Filmes.Handlers
{
    public class CreateFilmeCommandHandler : IRequestHandler<CreateFilmeCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateFilmeCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateFilmeCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Filmes.AddAsync(_mapper.Map<Filme>(request));
            return result;
        }
    }
}
