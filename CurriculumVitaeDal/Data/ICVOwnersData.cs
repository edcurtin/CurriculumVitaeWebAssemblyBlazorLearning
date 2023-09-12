using CurriculumVitae.Common.DAO;

namespace CurriculumVitae.Dal.Data
{
    public interface ICVOwnersData
    {
        Task<IEnumerable<CVOwnerDao>> GetCvOwners();
        Task InsertCVOwner(CVOwnerDao cvOwner);
    }
}