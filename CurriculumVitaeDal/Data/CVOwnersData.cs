using CurriculumVitae.Common.DAO;
using CurriculumVitae.Common.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Dal.Data
{
    public class CVOwnersData : ICVOwnersData
    {
        private ISqlDataAccess _sql;

        public CVOwnersData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public async Task<IEnumerable<CVOwnerDao>> GetCvOwners()
        {
            return await _sql.GetData<CVOwnerDao>("dbo.sp_CVOwners_GetAll");
        }

        public async Task InsertCVOwner(CVOwnerDao cvOwner)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add(@"Id", dbType: System.Data.DbType.Int32, direction: System.Data.ParameterDirection.Output);
            p.Add("@Name", cvOwner.Name);
            p.Add("@Address", cvOwner.Address);
            p.Add("@DateOfBirth", cvOwner.DateOfBirth);
            p.Add("@Email", cvOwner.Email);
            p.Add("@LinkedIn", cvOwner.LinkedIn);
            p.Add("@WorkingModel", cvOwner.WorkingModel);
            p.Add("@TelephoneNumber", cvOwner.TelephoneNumber);

            await _sql.SaveData("dbo.sp_CVOwner_Insert", p);
        }
    }

}
