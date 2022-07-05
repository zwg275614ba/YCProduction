using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCProduction.IService.IService.Dictionary;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.Dictionary;
using YCProduction.Model.SearchParam.Dictionary;
using YCProduction.Web.Controllers;

namespace YCProduction.Web.Areas.Dictionary.Controllers
{
    [Area("Dictionary")]
    public class IndustryCategoryController : BaseController
    {
        private readonly IDicIndustryCategoryService _dicIndustryCategoryService;

        public IndustryCategoryController(
           ISysUserRoleService sysUserRoleService,
           ISysActionService sysActionService,
           IDicIndustryCategoryService dicIndustryCategoryService)
            : base(sysUserRoleService, sysActionService)
        {
            this._dicIndustryCategoryService = dicIndustryCategoryService;
        }

        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetIndustryCategoryList(IndustryCategoryParam industryCategoryParam)
        {
            return Json(await _dicIndustryCategoryService.LoadListPage(industryCategoryParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddIndustryCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddIndustryCategory(DicIndustryCategory dicIndustryCategory)
        {
            if (_dicIndustryCategoryService.SelectAsync(hh => hh.IndustryCategoryId == dicIndustryCategory.IndustryCategoryId).Result.Count > 0)
                return Json(new { State = false, Message = "行业类别ID存在" });
            await _dicIndustryCategoryService.AddAsync(dicIndustryCategory);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditIndustryCategory(int id)
        {
            var model = await _dicIndustryCategoryService.GetAsync(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditIndustryCategory(DicIndustryCategory dicIndustryCategory)
        {
            await _dicIndustryCategoryService.UpdateAsync(dicIndustryCategory);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 删除
        [HttpPost]
        public async Task<IActionResult> DelInfo(int id)
        {
            await _dicIndustryCategoryService.DeleteKeyAsync(id);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

    }
}
