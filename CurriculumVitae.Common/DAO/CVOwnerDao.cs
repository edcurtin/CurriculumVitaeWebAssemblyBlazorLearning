using CurriculumVitae.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Common.DAO
{
    public class CVOwnerModelDao
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string LinkedIn { get; set; }

        public WorkingModel WorkingModel { get; set; }

        public string TelephoneNumber { get; set; }
    }
}
