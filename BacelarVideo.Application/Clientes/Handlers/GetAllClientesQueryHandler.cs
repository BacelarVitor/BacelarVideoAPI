using AutoMapper;
using IntcomTestApp.Application.Clientes.Dto;
using IntcomTestApp.Application.Clientes.Queries;
using IntcomTestApp.Application.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Clientes.Handlers
{
    public class GetAllClientesQueryHandler : IRequestHandler<GetAllClientesQuery, List<ClienteDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllClientesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<ClienteDto>> Handle(GetAllClientesQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Clientes.GetAllAsync();
            return _mapper.Map<List<ClienteDto>>(result.ToList());
        }
    }
}
