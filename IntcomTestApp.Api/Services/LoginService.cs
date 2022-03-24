using IntcomTestApp.Api.Helpers;
using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Application.Login.Models;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IntcomTestApp.Api.Services
{
    public class LoginService : ILoginService
    {
        private readonly AppSettings _appSettings;
        private readonly IUnitOfWork _unitOfWork;
        public LoginService(IOptions<AppSettings> appSettings, IUnitOfWork unitOfWork)
        {
            _appSettings = appSettings.Value;
            _unitOfWork = unitOfWork;
        }

        public async Task<Login> AuthenticateAsync(string email, string senha)
        {
            var cliente = await _unitOfWork.Clientes.GetLoginCredentialsAsync(email, senha);

            if (cliente == null)
                return null;

            var login = new Login()
            {
                Id = cliente.Id,
                Nome = cliente.Nome
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("id", login.Id.ToString()),
                    new Claim("nome", login.Nome.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            login.Token = tokenHandler.WriteToken(token);

            return login;
        }

    }
}
