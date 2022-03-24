using IntcomTestApp.Application.Filmes.Dto;
using MediatR;

namespace IntcomTestApp.Application.Filmes.Queries
{
    public class GetFilmeByIdQuery : IRequest<FilmeDto>
    {
        public int Id { get; set; }
    }
}
