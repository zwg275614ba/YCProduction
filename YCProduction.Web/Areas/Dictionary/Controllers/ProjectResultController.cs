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
    public class ProjectResultController : BaseController
    {
        private readonly IDicProjectResultService _dicProjectResultService;
        public ProjectResultController(
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService,
            IDicProjectResultService dicProjectResultService)
            : base(sysUserRoleService, sysActionService)
        {
            this._dicProjectResultService = dicProjectResultService;
        }

        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetProjectResultList(ProjectResultParam projectResultParam)
        {
            return Json(await _dicProjectResultService.LoadListPage(projectResultParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddProjectResult()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddProjectResult(DicProjectResult dicProjectResult)
        {
            //验证 职称ID是否存在
            if (_dicProjectResultService.SelectAsync(hh => hh.ResultId == dicProjectResult.ResultId).Result.Count > 0)
                return Json(new { State = false, Message = "投标或立项结果ID存在" });
            await _dicProjectResultService.AddAsync(dicProjectResult);
            return Json(new { State = true, Message = "操作成功" });
        }

        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditProjectResult(int id)
        {
            var model = await _dicProjectResultService.GetAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditProjectResult(DicProjectResult dicProjectResult)
        {
            await _dicProjectResultService.UpdateAsync(dicProjectResult);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 删除
        [HttpPost]
        public async Task<IActionResult> DelInfo(int id)
        {
            await _dicProjectResultService.DeleteKeyAsync(id);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion
    }
}
