using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YCProduction.IRepository.IRepository.System;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Service.BaseService;

namespace YCProduction.Service.Service.System
{
    public class SysMenuService : BaseService<SysMenu>, ISysMenuService
    {
        public SysMenuService(ISysMenuRepository sysMenuRepository)
        {
            SysMenuRepository = sysMenuRepository;
            base.BaseRepository = sysMenuRepository;
        }

        public ISysMenuRepository SysMenuRepository { get; }
        /// <summary>
        /// 获取登录用户菜单
        /// </summary>
        /// <param name="userId">登录用户id</param>
        /// <returns>返回登录用户对应菜单</returns>
        public async Task<string> GetMenuList(int userId)
        {
            return await SysMenuRepository.GetMenuList(userId);
        }
    }
}
