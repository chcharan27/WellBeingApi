using WellBeing.Services.MentelHealthApi.Models;

namespace WellBeing.Services.MentelHealthApi.Services.IService
{
    public interface IMoodTrackerService
    {
        IEnumerable<MoodTracker> GetUserMoodLog();

        IEnumerable<MoodTracker> GetUsersByDoctor(int docId);

        bool AddUserMoodLog(MoodTracker userMoodLog);

        bool UpdateUserMoodLog(MoodTracker userMoodLog);

        bool DeleteUserMoodLog(string id ,DateOnly date);





    }
}
