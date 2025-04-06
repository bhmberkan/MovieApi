using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesignPattern.Command.TagCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries;
using MovieApi.Application.Features.MediatorDesignPattern.Results.TagResult;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Taglist()
        {
            var values = await _mediator.Send(new GetTagQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Ekleme işlemi başarılı");
        }

        [HttpGet("GetTagById")]
        public async Task<IActionResult> GetTagById(int id)
        {
            var values =await _mediator.Send(new GetTagByIdQuery(id));
            return Ok(values);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTag(int id)
        {
           await _mediator.Send(new RemoveTagCommand(id));
            return Ok("Silme işlemi başarlı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
