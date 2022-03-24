using MediatR;
using System;

namespace IntcomTestApp.Application.Locacoes.Commands
{
    public class UpdateLocacaoCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int FilmeId { get; set; }
        public int ClienteId { get; set; }
        public bool Ativa { get; set; }
    }
}
