using IntcomTestApp.Application.Interfaces;

namespace IntcomTestApp.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IClienteRepository clienteRepository, IFilmeRepository filmeRepository, ILocacaoRepository locacaoRepository)
        {
            Clientes = clienteRepository;
            Filmes = filmeRepository;
            Locacoes = locacaoRepository;
        }

        public IClienteRepository Clientes { get; }
        public IFilmeRepository Filmes { get; }
        public ILocacaoRepository Locacoes { get; }

    }
}
