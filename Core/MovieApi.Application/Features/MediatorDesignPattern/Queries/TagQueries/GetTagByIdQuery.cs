using MediatR;
using MovieApi.Application.Features.MediatorDesignPattern.Results.TagResult;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries
{
    public class GetTagByIdQuery :IRequest<GetTagByIdQueryResult>
    {
       
        public int TagId { get; set; }

        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }
    }
}
