using WellBeing.Services.MentelHealthApi.Models;

namespace WellBeing.Services.MentelHealthApi.Services.IService
{
    public interface IMoodTrackerDtoService
    {
        IEnumerable<MoodTrackerDto> GetUserMood(string id);// get mood by id 

        MoodTrackerDto GetUserMoodByDate(string id);// get mood of perticular date 


    }
}
