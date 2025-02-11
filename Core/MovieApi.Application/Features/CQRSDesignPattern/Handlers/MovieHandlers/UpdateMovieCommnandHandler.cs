using MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommnandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommnandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handler(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            value.Title = command.Title;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Rating = command.Rating;
            value.Description = command.Description;
            value.Duration = command.Duration;
            value.RelaseDate = command.RelaseDate;
            value.CreatedYear = command.CreatedYear;
            value.Status = command.Status;
            await _context.SaveChangesAsync();
        }
    }
}
