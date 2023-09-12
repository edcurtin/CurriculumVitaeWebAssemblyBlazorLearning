using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Common.DAO
{
    public class EmploymentHistoryDao
    {
        public int Id { get; set; }

        public int Owner { get; set; }

        public string Role { get; set; }

        public string Company { get; set; }

        public string Dates { get; set; }

        public string Responsibilities { get; set; }

        public bool CurrentEmployment { get; set; }
    }
}
