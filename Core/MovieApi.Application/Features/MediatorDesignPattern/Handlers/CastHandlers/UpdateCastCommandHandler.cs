﻿using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Command.CastCommands;
using MovieApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext _context;

        public UpdateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.CastId);
            values.Surname = request.Surname;
            values.Overview = request.Overview;
            values.Biograpy = request.Biograpy;
            values.ImageUrl = request.ImageUrl;
            values.Name = request.Name;
            values.Title = request.Title;
            await _context.SaveChangesAsync();
        }
    }
}
