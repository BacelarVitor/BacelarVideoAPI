using AutoMapper;
using IntcomTestApp.Application.Filmes.Dto;
using IntcomTestApp.Application.Filmes.Queries;
using IntcomTestApp.Application.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Filmes.Handlers
{
    public class GetAllFilmesQueryHandler : IRequestHandler<GetAllFilmesQuery, List<FilmeDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllFilmesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<FilmeDto>> Handle(GetAllFilmesQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Filmes.GetAllAsync();
            return _mapper.Map<List<FilmeDto>>(result.ToList());
        }
    }
}
