using Dapper;

namespace CurriculumVitae.Dal.Data
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> GetData<T>(string storedProcedure, string connectionStringName = "Default");
        Task SaveData(string storedProcedure, DynamicParameters data, string connectionStringName = "Default");
    }
}