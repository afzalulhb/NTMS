﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTMS.DTO
{
    public  class UtilityOptionDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? Cost { get; set; }

        public int IsActive { get; set; }
    }
}
