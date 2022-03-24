using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IntcomTestApp.Application.Interfaces
{
    public interface ILoginService
    {
        Task<Login.Models.Login> AuthenticateAsync(string email, string senha);
    }
}
