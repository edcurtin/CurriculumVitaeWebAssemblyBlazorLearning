﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculumVitae.Common.DTO
{
    public class EmploymentHistoryDto
    {
        public int Owner { get; set; }

        public string Role { get; set; }

        public string Company { get; set; }

        public string Dates { get; set; }

        public string Responsibilities { get; set; }

        public bool CurrentEmployment { get; set; }
    }
}
