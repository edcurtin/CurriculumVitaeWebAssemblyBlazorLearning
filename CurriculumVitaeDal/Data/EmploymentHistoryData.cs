using CurriculumVitae.Common.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Dal.Data
{
    public class EmploymentHistoryData : IEmploymentHistoryData
    {
        private ISqlDataAccess _sql;

        public EmploymentHistoryData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public Task<IEnumerable<EmploymentHistoryDto>> GetEmploymentHistory()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EmploymentHistoryDto>> GetEmploymentHistory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task InsertEmploymentHistory(EmploymentHistoryDto empHistory)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add(@"Id", dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Output);
            p.Add("@Owner", empHistory.Owner);
            p.Add("@Role", empHistory.Role);
            p.Add("@Company", empHistory.Company);
            p.Add("@Dates", empHistory.Dates);
            p.Add("@Responsibilities", empHistory.Responsibilities);
            p.Add("@CurrentEmployment", empHistory.CurrentEmployment);

            await _sql.SaveData("sp_EmploymentHistory_Insert", p);
        }
    }
}
