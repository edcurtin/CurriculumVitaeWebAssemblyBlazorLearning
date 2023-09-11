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
        public async Task<IEnumerable<EmploymentHistoryDao>> EmploymentHistory()
        {
             IList<EmploymentHistoryDao> employmentHistory = new List<EmploymentHistoryDao>();

            var employmentHistoryFromDb = await _empHistory.GetEmploymentHistory();
            foreach (var empHistory in employmentHistoryFromDb)
            {
                var entity = _mapper.Map<EmploymentHistoryDto, EmploymentHistoryDao>(empHistory);
                employmentHistory.Add(entity);
            }

            return employmentHistory;
        }

        [HttpGet("{id:int}")]
        public async Task<IEnumerable<EmploymentHistoryDao>> EmploymentHistory(int id)
        {
            IList<EmploymentHistoryDao> employmentHistory = new List<EmploymentHistoryDao>();

            var employmentHistoryFromDb = await _empHistory.GetEmploymentHistory(id);
            foreach (var empHistory in employmentHistoryFromDb)
            {
                var entity = _mapper.Map<EmploymentHistoryDto, EmploymentHistoryDao>(empHistory);
                employmentHistory.Add(entity);
            }

            return employmentHistory;
        }

        // POST api/<EmploymentHistoryController>
        [HttpPost]
        public async Task PostAsync([FromBody] EmploymentHistoryDao model)
        {
            var entityForDb = _mapper.Map<EmploymentHistoryDao, EmploymentHistoryDto>(model);

            await _empHistory.InsertEmploymentHistory(entityForDb);
        }
    }
}
