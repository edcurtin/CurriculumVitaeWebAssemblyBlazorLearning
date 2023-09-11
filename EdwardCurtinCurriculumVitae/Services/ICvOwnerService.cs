using CurriculumVitae.Common.DTO;

namespace EdwardCurtinCurriculumVitae.Services
{
    public interface ICvOwnerService
    {
        Task<IEnumerable<CVOwnerDto>> GetCvOwners();
    }
}