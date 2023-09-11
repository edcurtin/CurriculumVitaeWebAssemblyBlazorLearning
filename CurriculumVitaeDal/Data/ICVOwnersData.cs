using CurriculumVitae.Common.DTO;

namespace CurriculumVitae.Dal.Data
{
    public interface ICVOwnersData
    {
        Task<IEnumerable<CVOwnerDto>> GetCvOwners();
        Task InsertCVOwner(CVOwnerDto cvOwner);
    }
}