using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCProduction.Common.ClientApi;
using YCProduction.Common.Tree;
using YCProduction.IService.IService.Base;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.Base;
using YCProduction.Model.Entitys.Values;
using YCProduction.Model.ViewModel;
using YCProduction.Web.Controllers;

namespace YCProduction.Web.Areas.Base.Controllers
{
    [Area("Base")]
    public class DepartmentController : BaseController
    {
        private readonly IBaseDepartmentService _baseDepartmentService;
        public DepartmentController(
            IBaseDepartmentService baseDepartmentService,
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService)
            : base(sysUserRoleService, sysActionService)
        {
            this._baseDepartmentService = baseDepartmentService;
        }

        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetDepartmentList()
        {
            var departmentList = await _baseDepartmentService.SelectAsync();
            return Json(new PagedData<BaseDepartment> { count = departmentList.Count, data = departmentList.ToList() });
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment(BaseDepartment model)
        {
            model.ParentId = string.IsNullOrEmpty(model.ParentId + "") ? -1 : int.Parse(model.ParentId + "");
            await _baseDepartmentService.AddAsync(model);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditDepartment(int id)
        {
            var departmentEntity = await _baseDepartmentService.GetAsync(h => h.Id == id);
            int pid = (int)departmentEntity.ParentId;
            var model = await _baseDepartmentService.GetAsync(h => h.Id == pid);
            ViewBag.ParentName = model == null ? "" : model.DepartmentName;
            return View(departmentEntity);
        }

        [HttpPost]
        public async Task<IActionResult> EditDepartment(BaseDepartment model)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            var menuEntity = await _baseDepartmentService.GetAsync(h => h.Id == model.Id);
            if (menuEntity != null)
            {
                menuEntity.DepartmentId = model.DepartmentId;
                menuEntity.ParentId = model.ParentId;
                menuEntity.DepartmentName = model.DepartmentName;
                menuEntity.Counts = model.Counts;
                menuEntity.Duty = model.Duty;
                menuEntity.Assessment = model.Assessment;
                menuEntity.Remarks = model.Remarks;
                await _baseDepartmentService.UpdateAsync(menuEntity);
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
            if (id <= 0)
                return Json(new { State = false, Message = "操作失败" });
            else
            {
                if (_baseDepartmentService.SelectAsync(hh => hh.ParentId == id).Result.Count > 0)
                {
                    return Json(new { State = false, Message = "存在子数据,不能删除" });
                }
                await _baseDepartmentService.DeleteKeyAsync(id);
                return Json(new { State = true, Message = "操作成功" });
            }
        }
        #endregion

        #region 部门树
        [HttpPost]
        public async Task<IActionResult> GetDepartmentTree()
        {
            var list = await _baseDepartmentService.SelectAsync();
            if (list.Count > 0)
            {
                List<NodeTree> listTree = new List<NodeTree>();
                foreach (var item in list)
                {
                    NodeTree nodeTree = new NodeTree
                    {
                        id = item.Id,
                        name = item.DepartmentName,
                        pId = item.ParentId,
                        open = true,
                        isParent = _baseDepartmentService.SelectAsync(h => h.ParentId == item.Id).Result.Count > 0 ? true : false
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
    }
}
