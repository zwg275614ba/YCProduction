using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YCProduction.Common.ClientApi;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.Values;
using YCProduction.Model.SearchParam.System;
using YCProduction.Web.Controllers;

namespace YCProduction.Web.Areas.System.Controllers
{
    [Area("System")]
    [Authorize]
    public class LogController : BaseController
    {
        private readonly ISysLogService _sysLogService;

        public LogController(ISysUserRoleService sysUserRoleService, ISysActionService sysActionService, ISysLogService sysLogService) : base(sysUserRoleService, sysActionService)
        {
            this._sysLogService = sysLogService;
        }
        public IActionResult Index()
        {
            ViewData["ActionList"] = GetToolBar(MenuId, 0);
            ViewData["ActionFormRightTop"] = GetToolBar(MenuId, ButtonPosition.OutForm);
            return View();
        }

        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetLogList(LogParam logParam)
        {
            return Json(await _sysLogService.LoadUserListPage(logParam));
        }
        #endregion

        #region 批量删除
        [HttpPost]
        public async Task<IActionResult> AllDel(string ids)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            if (!string.IsNullOrEmpty(ids))
            {

                var arr = ids.Split(',');
                List<int> intLst = new List<int>();
                if (arr.Length > 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(arr[i].Trim()))
                        {
                            intLst.Add(int.Parse(arr[i]));
                        }
                    }
                }
                var list = await _sysLogService.SelectAsync(h => intLst.Contains(h.Id));
                if (list.Count > 0)
                {

                    await _sysLogService.DeleteListAsync(list.ToList());
                }
                ajaxResult.State = true;
                ajaxResult.Message = "操作成功";
            }
            return Json(ajaxResult);
        }
        #endregion
    }
}
