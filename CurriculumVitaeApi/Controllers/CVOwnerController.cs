using AutoMapper;
using CurriculumVitae.Common.DAO;
using CurriculumVitae.Common.DTO;
using CurriculumVitae.Dal.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CurriculumVitae.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVOwnerController : ControllerBase
    {
        private IMapper _mapper;
        private ICVOwnersData _db;

        public CVOwnerController(IMapper mapper, ICVOwnersData db)
        {
            _mapper = mapper;
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<CVOwnerDto>> GetAllCvOwners()
        {
            IList<CVOwnerDto> cvOwners = new List<CVOwnerDto>();

            var cvOwnersList = await _db.GetCvOwners();
            foreach(var owner in cvOwnersList)
            {
                var entity = _mapper.Map<CVOwnerDao, CVOwnerDto>(owner);
                cvOwners.Add(entity);
            }

            return cvOwners;
        }

        // POST api/<CVOwerController>
        [HttpPost]
        public async Task PostAsync([FromBody] CVOwnerDto model)
        {
            var entityForDb = _mapper.Map<CVOwnerDto, CVOwnerDao>(model);

            await _db.InsertCVOwner(entityForDb);
        }

    }
}
