using IntcomTestApp.Application.Interfaces;
using IntcomTestApp.Application.Login.Dto;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IntcomTestApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult> Authenticate([FromBody] AuthenticateModel request)
        {
            var login = await _loginService.AuthenticateAsync(request.Email, request.Senha);
            if (login == null)
                return BadRequest(new { message = "Email e/ou Senha incorretos" });

            return Ok(login);
        }
    }
}
