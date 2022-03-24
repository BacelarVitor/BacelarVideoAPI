using AutoMapper;
using IntcomTestApp.Application.Clientes.Commands;
using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Core.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Clientes.Handlers
{
    public class UpdateClienteCommandHandler : IRequestHandler<UpdateClienteCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateClienteCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateClienteCommand request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Clientes.UpdateAsync(_mapper.Map<Cliente>(request));
            return result;
        }
    }
}
