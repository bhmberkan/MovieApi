using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Command.TagCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly MovieContext _context;

        public CreateTagCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            await _context.Tags.AddAsync(new Tags()
            {
                Title = request.Title
            });
            await _context.SaveChangesAsync();
        }
    }
}
