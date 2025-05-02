using AutoMapper;
using WellBeing.Services.WellBeingApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace WellBeing.Services.MentelHealthApi.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() 
        {
            CreateMap<ReminderScheduler, ReminderSchedulerDto>();
        }
     
    }
}
