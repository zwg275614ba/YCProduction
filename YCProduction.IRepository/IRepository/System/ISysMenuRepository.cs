using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YCProduction.IRepository.BaseRepository;
using YCProduction.Model.Entitys.System;

namespace YCProduction.IRepository.IRepository.System
{
    public interface ISysMenuRepository : IBaseRepository<SysMenu>
    {
        /// <summary>
        /// 获取登录用户菜单
        /// </summary>
        /// <param name="userId">登录用户id</param>
        /// <returns>返回登录用户对应菜单</returns>
        Task<string> GetMenuList(int userId);
    }
}
