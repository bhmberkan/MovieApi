using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesignPattern.Command.CastCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> CastList()
        {
            var value =await _mediator.Send(new GetCastQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<ActionResult> CreateCast(CreateCastCommand command)
        {
          await  _mediator.Send(command);
            return Ok("Ekleme işlemi Başarılı");
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteCast(int id)
        {
            // newleme sebebi remove cast commanda constructrue var
            await _mediator.Send(new RemoveCastCommand(id));
            return Ok("Silme işlemi başarılı");
        }

        [HttpGet("GetCastById")]
        public async Task<ActionResult> GetCastById(int id)
        {
            var value =await _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateCast(UpdateCastCommand command)
        {
           await _mediator.Send(command);
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
