﻿using WellBeing.Services.SafetyApi.Models;
using System;

namespace WellBeing.Services.SafetyApi.Services.IService
{
    public interface IReportIncidentDtoService
    {

        Task<IEnumerable<ReportIncidentDto>> GetUserEventData(int id);

        Task<IEnumerable<ReportIncidentDto>> GetUserEventByDate(int id , DateOnly date);
        
    }
}
