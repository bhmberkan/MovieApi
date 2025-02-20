using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResult;
using MovieApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(x => new GetMovieQueryResult() // manuel mapping
            {
                CoverImageUrl = x.CoverImageUrl,
                CreatedYear = x.CreatedYear,
                Description = x.Description,
                Duration = x.Duration,
                MovieId = x.MovieId,
                Rating = x.Rating,
                RelaseDate = x.RelaseDate,
                Status = x.Status,
                Title= x.Title 
            }).ToList();
        }
    }
}
