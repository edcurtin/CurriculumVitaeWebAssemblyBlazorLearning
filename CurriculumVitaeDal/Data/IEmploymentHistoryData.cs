using CurriculumVitae.Common.DAO;
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
        Task<IEnumerable<EmploymentHistoryDao>> GetEmploymentHistory();

        Task<IEnumerable<EmploymentHistoryDao>> GetEmploymentHistory(int id);

        Task InsertEmploymentHistory(EmploymentHistoryDao empHistory);
    }
}
