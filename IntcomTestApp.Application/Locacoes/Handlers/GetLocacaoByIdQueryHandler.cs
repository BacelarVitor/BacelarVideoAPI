using AutoMapper;
using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Application.Locacoes.Dto;
using IntcomTestApp.Application.Locacoes.Queries;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Locacoes.Handlers
{
    public class GetLocacaoByIdQueryHandler : IRequestHandler<GetLocacaoByClienteAndFilmeQuery, LocacaoDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetLocacaoByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<LocacaoDto> Handle(GetLocacaoByClienteAndFilmeQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Locacoes.GetByClienteIdAndFilmeIdAsync(request.ClienteId, request.FilmeId);
            return _mapper.Map<LocacaoDto>(result);
        }
    }
}
