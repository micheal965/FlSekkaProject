using Int.Core.DTOs.Auth;
using Int.Core.DTOs.Users;
namespace Int.Core.Services.Contrct
{
    public interface IAuthService
    {

        Task<UserDTO?> RegisterAsync(RegisterDTO registerDto);
        Task<UserDTO?> LoginAsync(LoginDTO loginDto);



    }
}
