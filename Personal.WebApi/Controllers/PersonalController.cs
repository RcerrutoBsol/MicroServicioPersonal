using MediatR;
using Microsoft.AspNetCore.Mvc;
using Personal.Application.Dto.Personal;
using Personal.Application.UseCases.Command.Personas.CrearPersonal;
using Personal.Application.UseCases.Queries.Personas.GetPersonaById;
using System;
using System.Threading.Tasks;

namespace Personal.WebApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PersonalController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PersonalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearPersonalCommand command)
        {
            Guid id = await _mediator.Send(command);

            if (id == Guid.Empty)
                return BadRequest();

            return Ok(id);
        }

        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> GetPersonaById([FromRoute] GetPersonaByIdQuery command)
        {
            PersonalDto result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

    }
}
