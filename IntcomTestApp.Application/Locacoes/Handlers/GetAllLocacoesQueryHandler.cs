using AutoMapper;
using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Application.Locacoes.Dto;
using IntcomTestApp.Application.Locacoes.Queries;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Locacoes.Handlers
{
    public class GetAllLocacoesQueryHandler : IRequestHandler<GetAllLocacoesByClienteQuery, List<LocacaoDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllLocacoesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<LocacaoDto>> Handle(GetAllLocacoesByClienteQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Locacoes.GetAllByClienteIdAsync(request.ClienteId);
            return _mapper.Map<List<LocacaoDto>>(result.ToList());
        }
    }
}
