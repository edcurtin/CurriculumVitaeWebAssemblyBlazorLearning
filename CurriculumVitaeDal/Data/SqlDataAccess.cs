using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CurriculumVitae.Dal.Data
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> GetData<T>(string storedProcedure, DynamicParameters data, string connectionStringName = "Default")
        {
            using var connection = new SqlConnection(_config.GetConnectionString(connectionStringName));
            var results = await connection.QueryAsync<T>(storedProcedure, data, null, null, System.Data.CommandType.StoredProcedure);
            return results;
        }

        public async Task SaveData(string storedProcedure,
                                DynamicParameters data,
                                string connectionStringName = "Default")
        {
            using var connection = new SqlConnection(_config.GetConnectionString(connectionStringName));
            await connection.ExecuteAsync(storedProcedure,
                                    data,
                                    commandType: System.Data.CommandType.StoredProcedure);
        }
    }
}
