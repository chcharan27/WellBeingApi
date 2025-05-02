using WellBeing.Services.SafetyApi.Models;
//using WellBeing.Services.WellBeingApi.Models;
using System;
using System.Collections.Generic;

namespace WellBeing.Services.SafetyApi.Services.IService
{
    public interface IReportIncidentService
    {
        Task<IEnumerable<ReportIncident>> GetUserReportLog();

        bool AddUserReportLog(ReportIncident userReportLog);

        bool UpdateUserReportLog(int id, DateOnly date,ReportIncident updatdincident);

        bool DeleteUserReportLog(int id , DateOnly date);
    }
}
