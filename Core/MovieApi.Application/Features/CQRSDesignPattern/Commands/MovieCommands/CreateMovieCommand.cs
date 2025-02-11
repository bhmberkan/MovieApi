using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands
{
    public class CreateMovieCommand
    {
        
        public string Title { get; set; }
        public string CoverImageUrl { get; set; }
        public Decimal Rating { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime RelaseDate { get; set; }
        public String CreatedYear { get; set; }
        public bool Status { get; set; }
    }
}
