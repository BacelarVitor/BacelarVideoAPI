using AutoMapper;
using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Application.Locacoes.Commands;
using IntcomTestApp.Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Locacoes.Handlers
{
    public class UpdateLocacaoCommandHandler : IRequestHandler<UpdateLocacaoCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateLocacaoCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateLocacaoCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Locacoes.UpdateAsync(_mapper.Map<Locacao>(request));
            return result;
        }
    }
}
