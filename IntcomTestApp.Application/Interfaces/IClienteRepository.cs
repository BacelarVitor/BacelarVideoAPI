using IntcomTestApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Task<Cliente> GetLoginCredentialsAsync(string Email, string Senha);
    }
}
