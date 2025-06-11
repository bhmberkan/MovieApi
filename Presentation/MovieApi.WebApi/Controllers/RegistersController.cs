using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.CQRSDesignPattern.Commands.UserRegisterCommands;
using MovieApi.Application.Features.CQRSDesignPattern.Handlers.UserRegisterHandlers;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly CreateUserRegisterCommandHandler _createuserRegisterCommandHandler;

        public RegistersController(CreateUserRegisterCommandHandler createuserRegisterCommandHandler)
        {
            _createuserRegisterCommandHandler = createuserRegisterCommandHandler;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserRegister(CreateUserRegisterCommand command)
        {
            await _createuserRegisterCommandHandler.Handle(command);
            return Ok("Kulllanıcı başarıyla kaydedildi");
        }
    }
}
