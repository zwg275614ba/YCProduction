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
    public class PositionalTitleController : BaseController
    {
        private readonly IBasePositionalTitleService _basePositionalTitleService;

        public PositionalTitleController(
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService,
            IBasePositionalTitleService basePositionalTitleService)
            : base(sysUserRoleService, sysActionService)
        {
            this._basePositionalTitleService = basePositionalTitleService;
        }


        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetPositionalTitleList(PositionalTitleParam positionalTitleParam)
        {
            return Json(await _basePositionalTitleService.LoadUserListPage(positionalTitleParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddPositionalTitle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddPositionalTitle(BasePositionalTitle basePositionalTitle)
        {
            //验证 职称ID是否存在
            if (_basePositionalTitleService.SelectAsync(hh => hh.Code == basePositionalTitle.Code).Result.Count > 0)
                return Json(new { State = false, Message = "职称ID存在" });
            await _basePositionalTitleService.AddAsync(basePositionalTitle);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 编辑
        [HttpGet]
        public async Task<IActionResult> EditPositionalTitle(int id)
        {
            var model = await _basePositionalTitleService.GetAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditPositionalTitle(BasePositionalTitle basePositionalTitle)
        {
            await _basePositionalTitleService.UpdateAsync(basePositionalTitle);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 删除
        [HttpPost]
        public async Task<IActionResult> DelInfo(int id)
        {
            await _basePositionalTitleService.DeleteKeyAsync(id);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion
    }
}
