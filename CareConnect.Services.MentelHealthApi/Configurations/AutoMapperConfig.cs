using AutoMapper;
using WellBeing.Services.MentelHealthApi.Models;

namespace WellBeing.Services.MentelHealthApi.Configurations
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<MoodTracker, MoodTrackerDto>();
        }
     
    }
}
