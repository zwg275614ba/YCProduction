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
    public class SetUpProjectCategoryController : BaseController
    {
        private readonly IDicSetUpProjectCategoryService _dicSetUpProjectCategoryService;

        public SetUpProjectCategoryController(
       ISysUserRoleService sysUserRoleService,
       ISysActionService sysActionService,
       IDicSetUpProjectCategoryService dicSetUpProjectCategoryService)
       : base(sysUserRoleService, sysActionService)
        {
            this._dicSetUpProjectCategoryService = dicSetUpProjectCategoryService;
        }

        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetSetUpProjectCategoryList(SetUpProjectCategoryParam projectCategoryParam)
        {
            return Json(await _dicSetUpProjectCategoryService.LoadListPage(projectCategoryParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddSetUpProjectCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddSetUpProjectCategory(DicSetUpProjectCategory dicSetUpProjectCategory)
        {
            //验证 职称ID是否存在
            if (_dicSetUpProjectCategoryService.SelectAsync(hh => hh.CategoryId == dicSetUpProjectCategory.CategoryId).Result.Count > 0)
                return Json(new { State = false, Message = "投标或立项结果ID存在" });
            await _dicSetUpProjectCategoryService.AddAsync(dicSetUpProjectCategory);
            return Json(new { State = true, Message = "操作成功" });
        }

        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditSetUpProjectCategory(int id)
        {
            var model = await _dicSetUpProjectCategoryService.GetAsync(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditSetUpProjectCategory(DicSetUpProjectCategory dicSetUpProjectCategory)
        {
            await _dicSetUpProjectCategoryService.UpdateAsync(dicSetUpProjectCategory);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 删除
        [HttpPost]
        public async Task<IActionResult> DelInfo(int id)
        {
            await _dicSetUpProjectCategoryService.DeleteKeyAsync(id);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion
    }
}
