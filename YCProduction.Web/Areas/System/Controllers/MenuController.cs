using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCProduction.Common.ClientApi;
using YCProduction.Common.Tree;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.Entitys.Values;
using YCProduction.Model.ViewModel;
using YCProduction.Web.Controllers;

namespace YCProduction.Web.Areas.System.Controllers
{
    [Area("System")]
    [Authorize]
    public class MenuController : BaseController
    {
        private readonly ISysMenuService _sysMenuService;

        public MenuController(
            ISysMenuService sysMenuService,
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService)
            : base(sysUserRoleService, sysActionService)
        {
            this._sysMenuService = sysMenuService;
        }
        public IActionResult Index()
        {
            ViewData["ActionList"] = GetToolBar(MenuId, 0);
            ViewData["ActionFormRightTop"] = GetToolBar(MenuId, ButtonPosition.OutForm);
            return View();
        }

        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetMenuList()
        {
            var menuList = await _sysMenuService.SelectAsync();
            return Json(new PagedData<SysMenu> { count = menuList.Count, data = menuList.ToList() });
        }
        #endregion

        #region 登录用户菜单
        [HttpGet]
        public async Task<IActionResult> GetUserMenu()
        {
            //获取登录用户id
            string strJosn = string.Empty;
            var userInfo = HttpContext.User.Claims.FirstOrDefault(hh => hh.Type.Equals("userId"));
            if (userInfo != null)
            {
                int.TryParse(userInfo.Value, out int userId);
                strJosn = await _sysMenuService.GetMenuList(userId);
            }
            return Content(strJosn);
        }
        #endregion

        #region 添加
        [HttpGet]
        public ActionResult AddMenu()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMenu(SysMenu model)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            model.CreateDate = DateTime.Now;
            model.CreateBy = LoginUserId;
            model.ParentId = string.IsNullOrEmpty(model.ParentId + "") ? -1 : int.Parse(model.ParentId + "");
            if (model.ParentId == -1)
            {
                model.MenuLevel = 1;
            }
            else
            {
                model.MenuLevel = _sysMenuService.GetAsync(h => h.Id == model.ParentId).Result.MenuLevel + 1;
            }
            model.Status = model.Status == 0 ? MenuStatus.Enable : MenuStatus.Disable;
            await _sysMenuService.AddAsync(model);
            ajaxResult.State = true;
            ajaxResult.Message = "操作成功";

            return Json(ajaxResult);
        }
        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditMenu(int id)
        {
            var menuEntity = await _sysMenuService.GetAsync(h => h.Id == id);
            int pid = (int)menuEntity.ParentId;
            var model = await _sysMenuService.GetAsync(h => h.Id == pid);
            ViewBag.ParentName = model == null ? "" : model.MenuName;
            return View(menuEntity);
        }

        [HttpPost]
        public async Task<IActionResult> EditMenu(SysMenu model)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            var menuEntity = await _sysMenuService.GetAsync(h => h.Id == model.Id);
            if (menuEntity != null)
            {
                menuEntity.MenuName = model.MenuName;
                menuEntity.ParentId = model.ParentId;
                menuEntity.MenuUrl = model.MenuUrl;
                menuEntity.MenuIccon = model.MenuIccon;
                menuEntity.OrderNo = model.OrderNo;
                menuEntity.Status = model.Status;
                menuEntity.UpdateBy = LoginUserId;
                menuEntity.UpdateDate = DateTime.Now;
                await _sysMenuService.UpdateAsync(menuEntity);
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
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            if (id > 0)
            {
                //验证是否存在子数据
                var list = await _sysMenuService.SelectAsync(h => h.ParentId == id);
                if (list.Count > 0)
                {
                    ajaxResult.Message = "存在子数据,删除失败";
                }
                else
                {
                    var menuEntity = await _sysMenuService.GetAsync(h => h.Id == id);
                    if (menuEntity != null && menuEntity.Id > 0)
                    {
                        //删除
                        await _sysMenuService.DeleteAsync(menuEntity);
                        ajaxResult.State = true;
                        ajaxResult.Message = "操作成功";
                    }
                }
            }
            return Json(ajaxResult);
        }
        #endregion

        #region 菜单树
        [HttpPost]
        public async Task<IActionResult> GetMenuTree()
        {
            var list = await _sysMenuService.SelectAsync();
            if (list.Count > 0)
            {
                List<NodeTree> listTree = new List<NodeTree>();
                foreach (var item in list)
                {
                    NodeTree nodeTree = new NodeTree
                    {
                        id = item.Id,
                        name = item.MenuName,
                        pId = item.ParentId,
                        open = true,
                        isParent = _sysMenuService.SelectAsync(h => h.ParentId == item.Id).Result.Count > 0 ? true : false
                    };
                    listTree.Add(nodeTree);
                }
                return Json(listTree);
            }
            else
            {
                return Content("[]");
            }
        }
        #endregion
        #region 图标
        [HttpGet]
        public IActionResult Icon()
        {
            return View();
        }
        #endregion
    }
}
