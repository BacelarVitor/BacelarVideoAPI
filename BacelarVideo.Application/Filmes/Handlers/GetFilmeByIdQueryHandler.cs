using AutoMapper;
using IntcomTestApp.Application.Filmes.Dto;
using IntcomTestApp.Application.Filmes.Queries;
using IntcomTestApp.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Filmes.Handlers
{
    public class GetFilmeByIdQueryHandler : IRequestHandler<GetFilmeByIdQuery, FilmeDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetFilmeByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<FilmeDto> Handle(GetFilmeByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Filmes.GetAsync(request.Id);
            return _mapper.Map<FilmeDto>(result);
        }
    }
}

