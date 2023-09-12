using CurriculumVitae.Common.DTO;
using System.Net.Http;

namespace EdwardCurtinCurriculumVitae.Services
{
    public interface IEmploymentHistoryService
    {
        Task<IEnumerable<EmploymentHistoryDto>> GetEmploymentHistory(int id);
    }
}
