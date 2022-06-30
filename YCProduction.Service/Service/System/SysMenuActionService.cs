using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.IRepository.IRepository.System;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Service.BaseService;

namespace YCProduction.Service.Service.System
{
    public class SysMenuActionService : BaseService<SysMenuAction>, ISysMenuActionService
    {
        public SysMenuActionService(ISysMenuActionRepository sysMenuActionRepository)
        {
            SysMenuActionRepository = sysMenuActionRepository;
            base.BaseRepository = sysMenuActionRepository;
        }

        public ISysMenuActionRepository SysMenuActionRepository { get; }
    }
}
