using AutoMapper;
using WellBeing.Services.SafetyApi.Models;

namespace WellBeing.Services.MentelHealthApi.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap <ReportIncident, ReportIncidentDto>();
            //CreateMap<ReportIncident, ReminderSchedulerDto>();
        }
     
    }
}
