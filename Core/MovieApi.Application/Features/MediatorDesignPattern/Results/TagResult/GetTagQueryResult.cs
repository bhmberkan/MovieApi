using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.MediatorDesignPattern.Results.TagResult
{
    public class GetTagQueryResult
    {
       
        public int TagId { get; set; }
        public string Title { get; set; }
    }
}
