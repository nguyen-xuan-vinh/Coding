using AutoMapper;
using Coding.WebApi.Entities;

namespace Coding.WebApi.Models.Dtos
{
    public class UserRegisterDto : Profile
    {
        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
        public UserRegisterDto()
        {
            CreateMap<User, UserRegisterDto>();
        }
    }
}
