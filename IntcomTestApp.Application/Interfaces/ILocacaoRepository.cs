using IntcomTestApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Interfaces
{
    public interface ILocacaoRepository : IRepository<Locacao>
    {
        Task<Locacao> GetByClienteIdAndFilmeIdAsync(int clienteId, int filmeId);
        Task<IEnumerable<Locacao>> GetAllByClienteIdAsync(int clienteId);
    }
}
