using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YCProduction.Common.Extend;
using YCProduction.IRepository.IRepository.System;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.SearchParam.System;
using YCProduction.Model.ViewModel;
using YCProduction.Service.BaseService;

namespace YCProduction.Service.Service.System
{
    public class SysRoleService : BaseService<SysRole>, ISysRoleService
    {
        public SysRoleService(ISysRoleRepository sysRoleRepository)
        {
            SysRoleRepository = sysRoleRepository;
            base.BaseRepository = sysRoleRepository;
        }

        public ISysRoleRepository SysRoleRepository { get; }
        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="roleParam"></param>
        /// <returns></returns>
        public async Task<PagedData<SysRole>> LoadUserListPage(RoleParam roleParam)
        {
            Expression<Func<SysRole, bool>> expression = ExtLinq.ExpressionTrue<SysRole>();
            if (!string.IsNullOrWhiteSpace(roleParam.RoleName))
            {
                expression = expression.And<SysRole>(hh => hh.RoleName.Contains(roleParam.RoleName));
            }
            return await SysRoleRepository.SelectPagedAsync(roleParam.page, roleParam.limit, expression, roleParam.field, roleParam.order);
        }
    }
}
