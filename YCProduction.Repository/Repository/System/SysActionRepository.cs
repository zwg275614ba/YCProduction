using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.IRepository;
using YCProduction.IRepository.IRepository.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Repository.BaseRepository;

namespace YCProduction.Repository.Repository.System
{
    public class SysActionRepository : BaseRepository<SysAction>, ISysActionRepository
    {
        public SysActionRepository(YCProductionDBContext dbContext) : base(dbContext)
        {
        }
    }
}
