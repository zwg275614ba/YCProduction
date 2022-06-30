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
using YCProduction.Model.SearchParam.System;
using YCProduction.Web.Controllers;

namespace YCProduction.Web.Areas.System.Controllers
{
    [Area("System")]
    [Authorize]
    public class ActionController : BaseController
    {
        private readonly ISysActionService _sysActionService;
        private readonly ISysMenuActionService _sysMenuActionService;
        private readonly ISysMenuService _sysMenuService;

        public ActionController(
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService,
            ISysMenuActionService sysMenuActionService,
            ISysMenuService sysMenuService)
            : base(sysUserRoleService, sysActionService)
        {
            this._sysActionService = sysActionService;
            this._sysMenuActionService = sysMenuActionService;
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
        public async Task<IActionResult> GetActionList(ActionParam actionParam)
        {
            return Json(await _sysActionService.LoadUserListPage(actionParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public ActionResult AddAction()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddAction(SysAction model)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            model.CreateDate = DateTime.Now;
            model.CreateBy = LoginUserId;
            await _sysActionService.AddAsync(model);
            ajaxResult.State = true;
            ajaxResult.Message = "操作成功";
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
                var actionEntity = await _sysActionService.GetAsync(h => h.Id == id);
                if (actionEntity != null && actionEntity.Id > 0)
                {
                    await _sysActionService.DeleteAsync(actionEntity);
                    ajaxResult.State = true;
                    ajaxResult.Message = "操作成功";
                }
            }
            return Json(ajaxResult);
        }
        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditAction(int id)
        {
            var actionEntity = await _sysActionService.GetAsync(h => h.Id == id);
            return View(actionEntity);
        }

        [HttpPost]
        public async Task<IActionResult> EditAction(SysAction model)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            var actionEntity = await _sysActionService.GetAsync(h => h.Id == model.Id);
            if (actionEntity != null && actionEntity.Id > 0)
            {
                actionEntity.ActionName = model.ActionName;
                actionEntity.ActionCode = model.ActionCode;
                actionEntity.Icon = model.Icon;
                actionEntity.Method = model.Method;
                actionEntity.OrderBy = model.OrderBy;
                actionEntity.Remark = model.Remark;
                actionEntity.Position = model.Position;
                actionEntity.ClassName = model.ClassName;
                actionEntity.UpdateBy = LoginUserId;
                actionEntity.UpdateDate = DateTime.Now;
                await _sysActionService.UpdateAsync(actionEntity);
                ajaxResult.State = true;
                ajaxResult.Message = "操作成功";
            }
            return Json(ajaxResult);
        }
        #endregion

        #region 分配功能
        [HttpGet]
        public ActionResult AllotAction(int id)
        {
            ViewBag.ActionId = id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AllotAction(int menuId, string ids)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            if (menuId > 0)
            {
                //删除原来的数据
                var oldActionList = await _sysMenuActionService.SelectAsync(h => h.MenuId == menuId);
                if (oldActionList.Count > 0)
                {
                    foreach (var item in oldActionList)
                    {
                        int id = item.Id;
                        var entity = await _sysMenuActionService.GetAsync(h => h.Id == id);
                        await _sysMenuActionService.DeleteAsync(entity);
                    }
                }
                //添加
                var strArr = ids.Split(',');
                if (strArr.Length > 0)
                {
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(strArr[i].Trim()))
                        {
                            SysMenuAction model = new SysMenuAction
                            {
                                MenuId = menuId,
                                ActionId = int.Parse(strArr[i] + "")
                            };
                            await _sysMenuActionService.AddAsync(model);
                        }
                    }
                }
                ajaxResult.State = true;
                ajaxResult.Message = "操作成功";
            }

            return Json(ajaxResult);
        }
        [HttpPost]
        public async Task<IActionResult> GetButtonTree(int id)
        {
            List<NodeTree> listTree = new List<NodeTree>();
            var menuEntity = await _sysMenuService.GetAsync(h => h.Id == id);
            if (menuEntity != null)
            {
                var actionList2 = _sysMenuActionService.SelectAsync(h => h.MenuId == menuEntity.Id).Result.AsQueryable().Select(h => h.ActionId).ToList();
                NodeTree nodeTree = new NodeTree
                {
                    id = menuEntity.Id + 999,
                    name = menuEntity.MenuName,
                    pId = 0,
                    open = true,
                    isParent = true,
                    @checked = actionList2.Count > 0 ? true : false
                };
                listTree.Add(nodeTree);
                var actionList = await _sysActionService.SelectAsync();
                if (actionList.Count > 0)
                {
                    foreach (var item in actionList)
                    {
                        NodeTree nodeTree2 = new NodeTree
                        {
                            id = item.Id,
                            name = item.ActionName,
                            pId = menuEntity.Id + 999,
                            open = true,
                            isParent = false,
                            @checked = actionList2.Contains(item.Id) ? true : false
                        };
                        listTree.Add(nodeTree2);
                    }
                }
                return Json(listTree);
            }
            else
            {
                return Content("[]");
            }
        }
        #endregion
    }
}
