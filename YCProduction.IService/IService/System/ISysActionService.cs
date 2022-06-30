using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YCProduction.IService.IBaseService;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.Entitys.Values;
using YCProduction.Model.SearchParam.System;
using YCProduction.Model.ViewModel;

namespace YCProduction.IService.IService.System
{
    public interface ISysActionService : IBaseService<SysAction>
    {
        /// <summary>
        /// 获取菜单按钮
        /// </summary>
        /// <param name="menuId"></param>
        /// <param name="roleId"></param>
        /// <param name="type">0:表内 1表外</param>
        /// <returns></returns>
        IEnumerable<SysAction> GetActionList(int? menuId, List<int> roleId, ButtonPosition type);
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="actionParam"></param>
        /// <returns></returns>
        Task<PagedData<SysAction>> LoadUserListPage(ActionParam actionParam);
    }
}
