using WellBeing.Services.AuthApi.models.Dto;

namespace WellBeing.Services.AuthApi.Service
{
    public interface IAuthService
    {
        //Task<string> Register(RegistrationRequestDto registrationRequestDto);
        //Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);

        //// this is for role management/.
        //Task<bool> AssignRole(string email, string rolename);

        Task<string> Register(RegistrationRequestDto registrationRequestDto);

        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
    }
}
