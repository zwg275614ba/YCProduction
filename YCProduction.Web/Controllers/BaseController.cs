using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.Entitys.Values;

namespace YCProduction.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly ISysUserRoleService _sysUserRoleService;
        private readonly ISysActionService _sysActionService;

        public BaseController(ISysUserRoleService sysUserRoleService, ISysActionService sysActionService)
        {
            this._sysUserRoleService = sysUserRoleService;
            this._sysActionService = sysActionService;
        }
        /// <summary>
        /// 获取菜单id
        /// </summary>
        protected int MenuId => string.IsNullOrEmpty(Request.Query["mpi"] + "") ? 0 : int.Parse(Request.Query["mpi"]);
        /// <summary>
        /// 获取登录用户名称
        /// </summary>
        protected string LoginUserName => HttpContext.User.Identity.Name;
        /// <summary>
        /// 获取登录用户Id
        /// </summary>
        protected int LoginUserId
        {
            get
            {
                var userInfo = HttpContext.User.Claims.FirstOrDefault(hh => hh.Type.Equals("userId"));
                int.TryParse(userInfo?.Value, out int userId);
                return userId;
            }
        }


        #region 获取菜单按钮
        public IEnumerable<SysAction> GetToolBar(int? menuId, ButtonPosition type)
        {
            var _menuId = menuId == null ? 0 : menuId;
            //获取用户角色
            var roleList = _sysUserRoleService.SelectAsync(h => h.UserId == LoginUserId).Result.AsQueryable().Select(h => h.RoleId).ToList();
            IEnumerable<SysAction> lst = _sysActionService.GetActionList(_menuId, roleList, type);
            return lst;
        }
        #endregion
    }
}
