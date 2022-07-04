using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCProduction.IService.IService.Base;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.Base;
using YCProduction.Model.SearchParam.Base;
using YCProduction.Web.Controllers;

namespace YCProduction.Web.Areas.Base.Controllers
{
    [Area("Base")]
    public class DutiesController : BaseController
    {
        private readonly IBaseDutiesService _baseDutiesService;

        public DutiesController(
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService,
            IBaseDutiesService baseDutiesService)
            : base(sysUserRoleService, sysActionService)
        {
            this._baseDutiesService = baseDutiesService;
        }


        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetDutiesList(DutiesParam dutiesParam)
        {
            return Json(await _baseDutiesService.LoadUserListPage(dutiesParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddDuties()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddDuties(BaseDuties baseDuties)
        {
            //验证 职称ID是否存在
            if (_baseDutiesService.SelectAsync(hh => hh.Code == baseDuties.Code).Result.Count > 0)
                return Json(new { State = false, Message = "职务ID存在" });
            await _baseDutiesService.AddAsync(baseDuties);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditDuties(int id)
        {
            var model = await _baseDutiesService.GetAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditDuties(BaseDuties baseDuties)
        {
            await _baseDutiesService.UpdateAsync(baseDuties);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 删除
        [HttpPost]
        public async Task<IActionResult> DelInfo(int id)
        {
            await _baseDutiesService.DeleteKeyAsync(id);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

    }
}
