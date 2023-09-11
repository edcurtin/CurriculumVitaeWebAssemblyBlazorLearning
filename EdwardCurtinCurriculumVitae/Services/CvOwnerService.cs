using CurriculumVitae.Common.DTO;
using System.Net.Http.Json;

namespace EdwardCurtinCurriculumVitae.Services
{
    public class CvOwnerService : ICvOwnerService
    {
        private HttpClient _httpClient;

        public CvOwnerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<CVOwnerDto>> GetCvOwners()
        {
            try
            {
                var res = await _httpClient.GetFromJsonAsync<IEnumerable<CVOwnerDto>>("/api/CVOwner");
                return res;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
