using AutoMapper;
using CurriculumVitae.Common.DAO;
using CurriculumVitae.Common.DTO;
using CurriculumVitae.Dal.Data;
using Microsoft.AspNetCore.Mvc;

namespace CurriculumVitae.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentHistoryController : ControllerBase
    {
        private IMapper _mapper;
        private IEmploymentHistoryData _empHistory;

        public EmploymentHistoryController(IMapper mapper, IEmploymentHistoryData db)
        {
            _mapper = mapper;
            _empHistory = db;
        }

        [HttpGet]
        public async Task<IEnumerable<EmploymentHistoryDto>> EmploymentHistory()
        {
             IList<EmploymentHistoryDto> employmentHistory = new List<EmploymentHistoryDto>();

            var employmentHistoryFromDb = await _empHistory.GetEmploymentHistory();
            foreach (var empHistory in employmentHistoryFromDb)
            {
                var entity = _mapper.Map<EmploymentHistoryDao, EmploymentHistoryDto>(empHistory);
                employmentHistory.Add(entity);
            }

            return employmentHistory;
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<EmploymentHistoryDto>> EmploymentHistory(int id)
        {
            IList<EmploymentHistoryDto> employmentHistory = new List<EmploymentHistoryDto>();

            var employmentHistoryFromDb = await _empHistory.GetEmploymentHistory(id);
            foreach (var empHistory in employmentHistoryFromDb)
            {
                var entity = _mapper.Map<EmploymentHistoryDao, EmploymentHistoryDto>(empHistory);
                employmentHistory.Add(entity);
            }

            return employmentHistory;
        }

        // POST api/<EmploymentHistoryController>
        [HttpPost]
        public async Task PostAsync([FromBody] EmploymentHistoryDto model)
        {
            var entityForDb = _mapper.Map<EmploymentHistoryDto, EmploymentHistoryDao>(model);

            await _empHistory.InsertEmploymentHistory(entityForDb);
        }
    }
}
