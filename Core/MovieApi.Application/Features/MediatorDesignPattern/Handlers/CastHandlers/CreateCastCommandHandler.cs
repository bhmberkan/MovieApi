using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Command.CastCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class CreateCastCommandHandler : IRequestHandler<CreateCastCommand>
    {
        private readonly MovieContext _context;

        public CreateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateCastCommand request, CancellationToken cancellationToken)
        {
          await  _context.Casts.AddAsync(new Cast()
            {
                Biograpy = request.Biograpy,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Overview = request.Overview,
                Surname = request.Surname,
                Title = request.Title
            });
            await _context.SaveChangesAsync();
           
           
        }


    }
}
