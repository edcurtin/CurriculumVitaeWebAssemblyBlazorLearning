using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Common.DTO
{
    public class CVOwnerDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string LinkedIn { get; set; }

        public WorkingModel WorkingModel { get; set; }

        public string TelephoneNumber { get; set; }
    }
}
