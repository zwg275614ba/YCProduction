using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.IRepository.IRepository.System;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Service.BaseService;

namespace YCProduction.Service.Service.System
{
    public class SysRoleMenuActionService : BaseService<SysRoleMenuAction>, ISysRoleMenuActionService
    {
        public SysRoleMenuActionService(ISysRoleMenuActionRepository sysRoleMenuActionRepository)
        {
            SysRoleMenuActionRepository = sysRoleMenuActionRepository;
            base.BaseRepository = sysRoleMenuActionRepository;
        }

        public ISysRoleMenuActionRepository SysRoleMenuActionRepository { get; }
    }
}
