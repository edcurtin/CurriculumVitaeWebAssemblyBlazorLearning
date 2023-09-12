using CurriculumVitae.Common.DTO;
using System.Net.Http.Json;

namespace EdwardCurtinCurriculumVitae.Services
{
    public class EmploymentHistoryService : IEmploymentHistoryService
    {
        private HttpClient _httpClient;

        public EmploymentHistoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<IEnumerable<EmploymentHistoryDto>> GetEmploymentHistory(int id)
        {
            try
            {
                var res = await _httpClient.GetFromJsonAsync<IEnumerable<EmploymentHistoryDto>>("/api/EmploymentHistory/" + id);
                return res;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
