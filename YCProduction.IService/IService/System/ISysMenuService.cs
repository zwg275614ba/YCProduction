using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YCProduction.IService.IBaseService;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IService.IService.System
{
    public interface ISysMenuService : IBaseService<SysMenu>
    {
        /// <summary>
        /// 获取登录用户菜单
        /// </summary>
        /// <param name="userId">登录用户id</param>
        /// <returns>返回登录用户对应菜单</returns>
        Task<string> GetMenuList(int userId);
    }
}
