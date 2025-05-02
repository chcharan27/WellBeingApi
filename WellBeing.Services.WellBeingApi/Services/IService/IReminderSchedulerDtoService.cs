using WellBeing.Services.WellBeingApi.Models;

namespace WellBeing.Services.WellBeingApi.Services.IService
{
    public interface IReminderSchedulerDtoService
    {

        IEnumerable<ReminderSchedulerDto> GetUserReminderByUser(string id,DateOnly date);

        
    }
}
