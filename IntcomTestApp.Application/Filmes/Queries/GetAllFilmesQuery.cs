using IntcomTestApp.Application.Filmes.Dto;
using MediatR;
using System.Collections.Generic;

namespace IntcomTestApp.Application.Filmes.Queries
{
    public class GetAllFilmesQuery : IRequest<List<FilmeDto>>
    {
    }
}
