using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCProduction.Common.ClientApi;
using YCProduction.IService.IService.Dictionary;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.Dictionary;
using YCProduction.Model.SearchParam.Dictionary;
using YCProduction.Web.Controllers;

namespace YCProduction.Web.Areas.Dictionary.Controllers
{
    [Area("Dictionary")]
    public class ProjectCategoryController : BaseController
    {
        private readonly ISysUserRoleService sysUserRoleService;
        private readonly ISysActionService sysActionService;
        private readonly IDicProjectCategoryService _dicProjectCategoryService;
        private readonly IDicIndustryCategoryService _dicIndustryCategoryService;

        public ProjectCategoryController(
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService,
            IDicProjectCategoryService dicProjectCategoryService,
            IDicIndustryCategoryService dicIndustryCategoryService)
            : base(sysUserRoleService, sysActionService)
        {
            this.sysUserRoleService = sysUserRoleService;
            this.sysActionService = sysActionService;
            this._dicProjectCategoryService = dicProjectCategoryService;
            this._dicIndustryCategoryService = dicIndustryCategoryService;
        }
        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetProjectCategoryList(ProjectCategoryParam projectCategoryParam)
        {
            return Json(await _dicProjectCategoryService.LoadListPage(projectCategoryParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddProjectCategory()
        {
            ViewBag.IndustryCategoryId = IndustryCategorys();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProjectCategory(DicProjectCategory dicProjectCategory)
        {
            if (_dicProjectCategoryService.SelectAsync(hh => hh.ProjectCategoryId == dicProjectCategory.ProjectCategoryId).Result.Count > 0)
                return Json(new { State = false, Message = "项目类别ID存在" });
            await _dicProjectCategoryService.AddAsync(dicProjectCategory);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditProjectCategory(int id)
        {
            var model = await _dicProjectCategoryService.GetAsync(id);
            ViewBag.IndustryCategoryId = IndustryCategorys(model.IndustryCategoryId);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditProjectCategory(DicProjectCategory dicProjectCategory)
        {
            await _dicProjectCategoryService.UpdateAsync(dicProjectCategory);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 删除
        [HttpPost]
        public async Task<IActionResult> DelInfo(int id)
        {
            await _dicProjectCategoryService.DeleteKeyAsync(id);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 行业列表
        [HttpPost]
        public List<SelectListItem> IndustryCategorys(string industryCategoryId = "")
        {
            var listData = _dicIndustryCategoryService.SelectAsync().Result;
            List<SelectListItem> selectList = new List<SelectListItem>();
            if (listData.Count > 0)
            {
                foreach (var item in listData)
                {
                    selectList.Add(new SelectListItem
                    {
                        Text = item.IndustryCategory,
                        Value = item.IndustryCategoryId + "",
                        Selected = item.IndustryCategoryId.Equals(industryCategoryId) ? true : false
                    });
                }
            }
            return selectList;
        }
        #endregion
    }
}
