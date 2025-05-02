using WellBeing.Services.AuthApi.models.Dto;

namespace WellBeing.Services.AuthApi.Service
{
    public interface IConsumerService
    {
        Task<List<ConsumerDto>> GetUsersByRole(string role);
    }
}
