using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YCProduction.Common.ClientApi;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.Entitys.Values;
using YCProduction.Model.SearchParam.System;
using YCProduction.Web.Controllers;

namespace YCProduction.Web.Areas.System.Controllers
{
    [Area("System")]
    public class RoleController : BaseController
    {
        private readonly ISysActionService _sysActionService;
        private readonly ISysRoleService _sysRoleService;
        private readonly ISysMenuService _sysMenuService;
        private readonly ISysRoleMenuActionService _sysRoleMenuActionService;
        private readonly ISysMenuActionService _sysMenuActionService;

        public RoleController(
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService,
            ISysRoleService sysRoleService,
            ISysMenuService sysMenuService,
            ISysRoleMenuActionService sysRoleMenuActionService,
            ISysMenuActionService sysMenuActionService)
            : base(sysUserRoleService, sysActionService)
        {
            this._sysActionService = sysActionService;
            this._sysRoleService = sysRoleService;
            this._sysMenuService = sysMenuService;
            this._sysRoleMenuActionService = sysRoleMenuActionService;
            this._sysMenuActionService = sysMenuActionService;
        }

        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetRoleList(RoleParam roleParam)
        {
            return Json(await _sysRoleService.LoadUserListPage(roleParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddInfo(SysRole model)
        {
            AjaxResult ajaxResult = new AjaxResult();
            model.CreateDate = DateTime.Now;
            model.CreateBy = LoginUserId;
            await _sysRoleService.AddAsync(model);
            ajaxResult.State = true;
            ajaxResult.Message = "操作成功";
            return Json(ajaxResult);
        }
        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditRole(int id)
        {
            var roleEntity = await _sysRoleService.GetAsync(h => h.Id == id);
            return View(roleEntity);
        }

        [HttpPost]
        public async Task<IActionResult> EditInfo(SysRole model)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            var roleEntity = await _sysRoleService.GetAsync(h => h.Id == model.Id);
            if (roleEntity != null && roleEntity.Id > 0)
            {
                roleEntity.RoleName = model.RoleName;
                roleEntity.Status = model.Status;
                roleEntity.Remark = model.Remark;
                roleEntity.UpdateBy = LoginUserId;
                roleEntity.UpdateDate = DateTime.Now;
                await _sysRoleService.UpdateAsync(roleEntity);
                ajaxResult.State = true;
                ajaxResult.Message = "操作成功";
            }
            return Json(ajaxResult);
        }
        #endregion

        #region 删除
        [HttpPost]
        public async Task<IActionResult> DelInfo(int id)
        {
            await _sysRoleService.DeleteKeyAsync(id);
            return Json(new AjaxResult { State = true, Message = "操作成功" });
        }
        #endregion

        #region 分配权限
        [HttpGet]
        public ActionResult AllotMenu(int id, string roleName)
        {
            ViewBag.RoleId = id;
            ViewBag.RoleName = roleName;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AllotMenu(int roleId)
        {
            StringBuilder sb = new StringBuilder();
            //获取菜单
            var menuList = await _sysMenuService.SelectAsync();
            if (menuList.Count > 0)
            {
                //获取一级菜单
                var level_1Menu = menuList.Where(h => h.MenuLevel == 1).ToList();
                if (level_1Menu.Count > 0)
                {
                    foreach (var menu1 in level_1Menu)
                    {
                        sb.Append("<tr><td><span class=\"folder-open\"></span>");
                        sb.Append(menu1.MenuName);
                        sb.Append("</td><td></td><td></td><td></td></tr>");
                        //获取二级菜单
                        var level_2Menu = menuList.Where(h => h.ParentId == menu1.Id && h.MenuLevel == 2).ToList();
                        if (level_2Menu.Count > 0)
                        {
                            foreach (var menu2 in level_2Menu)
                            {
                                sb.Append("<tr><td> <span class=\"folder-line\"></span><span class=\"folder-open\"></span>");
                                sb.Append(menu2.MenuName);
                                sb.Append("</td><td></td><td></td><td></td></tr>");
                                //获取三级菜单
                                var level_3Menu = menuList.Where(h => h.ParentId == menu2.Id && h.MenuLevel == 3).ToList();
                                if (level_3Menu.Count > 0)
                                {
                                    foreach (var menu3 in level_3Menu)
                                    {
                                        sb.Append("<tr><td> <span style=\"display:inline-block; width:24px; \"></span><span class=\"folder-line\"></span><span class=\"folder-open\"></span>");
                                        sb.Append(menu3.MenuName);
                                        //验证三级菜单是否选中
                                        var m = await _sysRoleMenuActionService.GetAsync(h => h.MenuId == menu3.Id && h.ActionId == 0 && h.RoleId == roleId);
                                        var isCheck = m != null ? true : false;
                                        sb.Append("</td><td>");
                                        if (isCheck)
                                        {
                                            sb.Append(string.Format(" <input type=\"checkbox\"  tag='cbx_{0}' checked>", menu3.Id));
                                        }
                                        else
                                        {
                                            sb.Append(string.Format(" <input type=\"checkbox\"  tag='cbx_{0}'>", menu3.Id));
                                        }
                                        sb.Append("<label class=\"lab\">显示</label></td>");
                                        //获取按钮
                                        sb.Append("<td>");
                                        var actionList = _sysMenuActionService.SelectAsync(h => h.MenuId == menu3.Id).Result.AsQueryable().Select(h => h.ActionId).ToList().Distinct();
                                        if (actionList.Count() > 0)
                                        {
                                            //获取所有按钮
                                            var actionList_2 = await _sysActionService.SelectAsync();
                                            foreach (var item in actionList)
                                            {
                                                var entity = actionList_2.Where(h => h.Id == item).FirstOrDefault();
                                                var actionName = entity == null ? "" : entity.ActionName;
                                                var actionId = entity == null ? 0 : entity.Id;
                                                //验证按钮是否选中
                                                var mm = await _sysRoleMenuActionService.GetAsync(h => h.MenuId == menu3.Id && h.ActionId == item && h.RoleId == roleId);
                                                var isCheck_2 = mm != null ? true : false;
                                                if (isCheck_2)
                                                {
                                                    sb.Append(string.Format("<input type=\"checkbox\" value='{0}' name='cbx_{1}' checked><label class=\"lab\">{2}</label>", actionId, menu3.Id, actionName));
                                                }
                                                else
                                                {
                                                    sb.Append(string.Format("<input type=\"checkbox\" value='{0}' name='cbx_{1}'><label class=\"lab\">{2}</label>", actionId, menu3.Id, actionName));
                                                }
                                            }
                                        }
                                        sb.Append("</td>");
                                        sb.Append("<td><span _target=\"unall\" class=\"layui-btn layui-btn-normal layui-btn-xs\">取消</span>");
                                        sb.Append("<span  _target=\"all\" class=\"layui-btn layui-btn-normal layui-btn-xs\">全选</span></td></tr>");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return Content(sb.ToString());
        }

        [HttpPost]
        public async Task<IActionResult> AddRMA(int roleId, string list)
        {
            List<SysRoleMenuAction> _list = JsonConvert.DeserializeObject<List<SysRoleMenuAction>>(list);
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            //删除原数据
            var oldList = await _sysRoleMenuActionService.SelectAsync(h => h.RoleId == roleId);
            if (oldList.Count > 0)
            {
                foreach (var item in oldList)
                {
                    var entity = await _sysRoleMenuActionService.GetAsync(h => h.Id == item.Id);
                    if (entity != null)
                    {
                        await _sysRoleMenuActionService.DeleteAsync(entity);
                    }
                }
            }
            //添加权限
            if (_list.Count > 0)
            {
                foreach (var item2 in _list)
                {
                    SysRoleMenuAction model = new SysRoleMenuAction
                    {
                        ActionId = item2.ActionId,
                        RoleId = item2.RoleId,
                        MenuId = item2.MenuId
                    };
                    await _sysRoleMenuActionService.AddAsync(model);
                }
            }
            ajaxResult.State = true;
            ajaxResult.Message = "操作成功";
            return Json(ajaxResult);
        }
        #endregion
    }
}
