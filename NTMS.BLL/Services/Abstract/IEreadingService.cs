﻿using NTMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTMS.BLL.Services.Abstract
{
    public interface IEreadingService
    {
        Task<EreadingDTO>LoadReading(int meterId, string firstDate,string lastDate);
        Task<EreadingDTO>Create(EreadingDTO model);
        Task<bool>Edit(EreadingDTO model);
        Task<bool> Delete(int id);
        Task<EreadingDTO> GetLastReading(int meterId);

    }
}
