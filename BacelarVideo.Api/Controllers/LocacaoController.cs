using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntcomTestApp.Application.Locacoes.Commands;
using IntcomTestApp.Application.Locacoes.Dto;
using IntcomTestApp.Application.Locacoes.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IntcomTestApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LocacaoController : ApiController
    {
        private int _clienteId;
        public LocacaoController()
        {
            //_clienteId = Convert.ToInt32((from c in HttpContext.User.Claims where c.Type == "id" select c.Value).FirstOrDefault());
        }
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateLocacaoCommand command)
        {
            return await Mediator.Send(command);        
        }

        [HttpGet]
        public async Task<ActionResult<List<LocacaoDto>>> GetAll()
        {
            _clienteId = Convert.ToInt32((from c in HttpContext.User.Claims where c.Type == "id" select c.Value).FirstOrDefault());
            return await Mediator.Send(new GetAllLocacoesByClienteQuery { ClienteId = _clienteId });
        }

        [HttpGet("{filmeId}")]
        public async Task<ActionResult<LocacaoDto>> Get(int filmeId)
        {
            _clienteId = Convert.ToInt32((from c in HttpContext.User.Claims where c.Type == "id" select c.Value).FirstOrDefault());
            return await Mediator.Send(new GetLocacaoByClienteAndFilmeQuery { ClienteId = _clienteId, FilmeId = filmeId });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateLocacaoCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
