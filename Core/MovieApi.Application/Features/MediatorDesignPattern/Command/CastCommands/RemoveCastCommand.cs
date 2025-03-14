using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Command.CastCommands
{
    public class RemoveCastCommand : IRequest
    {
        public RemoveCastCommand(int castId)
        {
            CastId = castId;
        }

        public int CastId { get; set; }
    }
}
