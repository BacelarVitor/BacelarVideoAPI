using System.Collections.Generic;
using System.Threading.Tasks;
using IntcomTestApp.Application.Clientes.Commands;
using IntcomTestApp.Application.Clientes.Dto;
using IntcomTestApp.Application.Clientes.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace IntcomTestApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ApiController
    {
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateClienteCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteDto>>> GetAll()
        {
            return await Mediator.Send(new GetAllClientesQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteDto>> Get(int id)
        {
            return await Mediator.Send(new GetClienteByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateClienteCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
