using System;

namespace IntcomTestApp.Application.Locacoes.Dto
{
    public class LocacaoDto
    {
        public int Id { get; set; }
        public int FilmeId { get; set; }
        public int ClienteId { get; set; }
        public bool Ativa { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
