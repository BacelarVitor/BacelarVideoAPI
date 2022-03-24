using AutoMapper;
using IntcomTestApp.Application.Clientes.Commands;
using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Clientes.Handlers
{
    public class CreatedClienteCommandHandler : IRequestHandler<CreateClienteCommand, int>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreatedClienteCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateClienteCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Clientes.AddAsync(_mapper.Map<Cliente>(request));
            return result;
        }
    }
}
