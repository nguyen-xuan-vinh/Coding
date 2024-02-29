using Coding.WebApi.Models.Dtos;
using Coding.WebApi.Models;
using Coding.WebApi.Entities;

namespace Coding.WebApi.Services.Interface
{
    public interface IUserService
    {
        Task<UserLoginDto> LoginAsync(UserLoginRequest request);

        Task<UserRegisterDto> RegisterAsync(UserRegisterRequest request);

        Task<User> GetUserByIdAsync(int userId);
    }
}
