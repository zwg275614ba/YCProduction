using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.IRepository.IRepository.System;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Service.BaseService;
using System.Linq;
using YCProduction.Model.Entitys.Values;
using System.Threading.Tasks;
using YCProduction.Model.ViewModel;
using YCProduction.Model.SearchParam.System;
using System.Linq.Expressions;
using YCProduction.Common.Extend;

namespace YCProduction.Service.Service.System
{
    public class SysActionService : BaseService<SysAction>, ISysActionService
    {
        public ISysActionRepository SysActionRepository { get; }
        public ISysRoleMenuActionService SysRoleMenuActionService { get; }

        public SysActionService(ISysActionRepository sysActionRepository, ISysRoleMenuActionService sysRoleMenuActionService)
        {
            SysActionRepository = sysActionRepository;
            SysRoleMenuActionService = sysRoleMenuActionService;
            base.BaseRepository = sysActionRepository;
        }
        /// <summary>
        /// 获取菜单按钮
        /// </summary>
        /// <param name="menuId"></param>
        /// <param name="roleId"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public IEnumerable<SysAction> GetActionList(int? menuId, List<int> roleId, ButtonPosition type)
        {
            List<SysAction> lst = null;
            List<int?> actionIdsList = SysRoleMenuActionService.SelectAsync(h => h.MenuId == menuId && roleId.Contains(h.RoleId)).Result.AsQueryable().Select(h => h.ActionId).ToList();
            if (actionIdsList.Count > 0)
            {
                lst = SysActionRepository.SelectAsync(h => actionIdsList.Contains(h.Id) && h.Position == type).Result.AsQueryable().OrderBy(h => h.OrderBy).ToList();
            }
            return lst;
        }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="actionParam"></param>
        /// <returns></returns>
        public async Task<PagedData<SysAction>> LoadUserListPage(ActionParam actionParam)
        {
            Expression<Func<SysAction, bool>> expression = ExtLinq.ExpressionTrue<SysAction>();
            if (!string.IsNullOrWhiteSpace(actionParam.ActionName))
            {
                expression = expression.And<SysAction>(hh => hh.ActionName.Contains(actionParam.ActionName));
            }
            return await SysActionRepository.SelectPagedAsync(actionParam.page, actionParam.limit, expression, actionParam.field, actionParam.order);
        }
    }
}
