using JWTWebApiAuth.Core.Dtos;

namespace JWTWebApiAuth.Core.Interfaces
{
    public interface IAuthService
    {
        Task<AuthServiceResponseDto> SeedRoleAsync();

        Task<AuthServiceResponseDto> RegisterAsync(RegisterDto registerDto);

        Task<AuthServiceResponseDto> LoginAsync(LoginDto loginDto);

        Task<AuthServiceResponseDto> MakeAdminAsync(UpdatePermissionDto updatePermissionDto);

        Task<AuthServiceResponseDto> MakeOwnerAsync(UpdatePermissionDto updatePermissionDto);


    }
}
