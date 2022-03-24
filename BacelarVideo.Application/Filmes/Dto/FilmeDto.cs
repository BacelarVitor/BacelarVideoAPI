using System;

namespace IntcomTestApp.Application.Filmes.Dto
{
    public class FilmeDto
    {
        public int Id { get; set; }
        public string Duracao { get; set; }
        public int AnoLancamento { get; set; }
        public string Sinopse { get; set; }
        public string Titulo { get; set; }
        public string Direcao { get; set; }
        public string Capa { get; set; }
        public string Generos { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
