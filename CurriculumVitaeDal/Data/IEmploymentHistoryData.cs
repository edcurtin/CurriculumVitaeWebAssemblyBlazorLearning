using CurriculumVitae.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Dal.Data
{
    public interface IEmploymentHistoryData
    {
        Task<IEnumerable<EmploymentHistoryDto>> GetEmploymentHistory();

        Task<IEnumerable<EmploymentHistoryDto>> GetEmploymentHistory(int id);

        Task InsertEmploymentHistory(EmploymentHistoryDto empHistory);
    }
}
