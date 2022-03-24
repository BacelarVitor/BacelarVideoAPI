namespace IntcomTestApp.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IClienteRepository Clientes { get; }
        IFilmeRepository Filmes { get; }
        ILocacaoRepository Locacoes { get; }
    }
}
