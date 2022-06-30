using System;
using System.Collections.Generic;
using System.Linq;
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
    public class SysUserService : BaseService<SysUser>, ISysUserService
    {
        public ISysUserRepository SysUserRepository { get; }
        public SysUserService(ISysUserRepository sysUserRepository)
        {
            SysUserRepository = sysUserRepository;
            base.BaseRepository = sysUserRepository;
        }
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="userParam"></param>
        /// <returns></returns>
        public async Task<PagedData<SysUser>> LoadUserListPage(UserParam userParam)
        {
            Expression<Func<SysUser, bool>> expression = ExtLinq.ExpressionTrue<SysUser>();
            if (!string.IsNullOrWhiteSpace(userParam.UserName))
            {
                expression = expression.And<SysUser>(hh=>hh.UserName.Contains(userParam.UserName));
            }
            return await SysUserRepository.SelectPagedAsync(userParam.page,userParam.limit,expression,userParam.field,userParam.order);
        }
    }
}
