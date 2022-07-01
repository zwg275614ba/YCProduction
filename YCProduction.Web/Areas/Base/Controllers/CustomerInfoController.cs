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
    public class CustomerInfoController : BaseController
    {
        private readonly IBaseCustomerInfoService _baseCustomerInfoService;

        public CustomerInfoController(
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService,
            IBaseCustomerInfoService baseCustomerInfoService)
            : base(sysUserRoleService, sysActionService)
        {
            this._baseCustomerInfoService = baseCustomerInfoService;
        }

        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetCustomerInfoList(CustomerInfoParam customerInfoParam)
        {
            return Json(await _baseCustomerInfoService.LoadUserListPage(customerInfoParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddCustomerInfo()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomerInfo(BaseCustomerInfo baseCustomerInfo)
        {
            await _baseCustomerInfoService.AddAsync(baseCustomerInfo);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 编
        [HttpGet]
        public async Task<IActionResult> EditCustomerInfo(int id)
        {
            var entity = await _baseCustomerInfoService.GetAsync(id);
            return View(entity);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> EditCustomerInfo(BaseCustomerInfo baseCustomerInfo)
        {
            await _baseCustomerInfoService.UpdateAsync(baseCustomerInfo);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion

        #region 删除
        [HttpPost]
        public async Task<IActionResult> DelInfo(int id)
        {
            await _baseCustomerInfoService.DeleteKeyAsync(id);
            return Json(new { State = true, Message = "操作成功" });
        }
        #endregion
    }
}
