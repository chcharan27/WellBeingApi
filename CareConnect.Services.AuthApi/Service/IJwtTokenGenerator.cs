using WellBeing.Services.AuthApi.models;

namespace WellBeing.Services.AuthApi.Service
{
    public interface IJwtTokenGenerator
    {
        Task<string> GenerateToken(ApplicationUser applicationUser);
    }
}
