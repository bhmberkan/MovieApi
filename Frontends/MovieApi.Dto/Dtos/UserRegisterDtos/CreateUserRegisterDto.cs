using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Dto.Dtos.UserRegisterDtos
{
    public class CreateUserRegisterDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string UserName{ get; set; }
        public string Password { get; set; }
    }
}
