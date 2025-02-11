using MovieApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handler(RemoveCategoryCommand command) // int id yerine id ye karşılık gelen sınıfımızı kullandık
        {
            var value = await _context.Categories.FindAsync(command.CategoryId);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync();
        }

    }
}
