using AutoMapper;
using IntcomTestApp.Application.Clientes.Dto;
using IntcomTestApp.Application.Clientes.Queries;
using IntcomTestApp.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Clientes.Handlers
{
    public class GetClienteByIdQueryHandler : IRequestHandler<GetClienteByIdQuery, ClienteDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetClienteByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ClienteDto> Handle(GetClienteByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Clientes.GetAsync(request.Id);
            return _mapper.Map<ClienteDto>(result);
        }
    }
}
