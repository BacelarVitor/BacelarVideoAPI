using System.Collections.Generic;
using System.Threading.Tasks;
using IntcomTestApp.Application.Filmes.Commands;
using IntcomTestApp.Application.Filmes.Dto;
using IntcomTestApp.Application.Filmes.Queries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IntcomTestApp.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateFilmeCommand command)
        {
            return await Mediator.Send(command);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<FilmeDto>>> GetAll()
        {
            return await Mediator.Send(new GetAllFilmesQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FilmeDto>> Get(int id)
        {
            return await Mediator.Send(new GetFilmeByIdQuery { Id = id });
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdateFilmeCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(int id)
        {
            return await Mediator.Send(new DeleteFilmeCommand { Id = id });
        }
    }
}
