using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.IRepository.IRepository.System;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Service.BaseService;

namespace YCProduction.Service.Service.System
{
    public class SysUserRoleService : BaseService<SysUserRole>, ISysUserRoleService
    {
        public SysUserRoleService(ISysUserRoleRepository sysUserRoleRepository)
        {
            SysUserRoleRepository = sysUserRoleRepository;
            base.BaseRepository = sysUserRoleRepository;
        }

        public ISysUserRoleRepository SysUserRoleRepository { get; }
    }
}
