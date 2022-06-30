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
    public class SysRoleMenuActionRepository : BaseRepository<SysRoleMenuAction>, ISysRoleMenuActionRepository
    {
        public SysRoleMenuActionRepository(YCProductionDBContext dbContext) : base(dbContext)
        {
        }
    }
}
