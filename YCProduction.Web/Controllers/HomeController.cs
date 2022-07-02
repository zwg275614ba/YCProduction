using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YCProduction.IService.IService.System;
using YCProduction.Web.Models;

namespace YCProduction.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISysMenuService _sysMenuService;

        public HomeController(ILogger<HomeController> logger, ISysMenuService sysMenuService)
        {
            _logger = logger;
            this._sysMenuService = sysMenuService;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["UserName"] = HttpContext.User.Identity.Name;
            ViewData["Photo"] = $"<img src='http://easyadmin.99php.cn/static/admin/images/head.jpg' width='50' height='50' class='layui-nav-img'>";
            ViewData["menus"] = await GetUserMenu();
            return View();
        }

        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }
        /// <summary>
        /// 获取登录用户菜单
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetUserMenu()
        {
            //获取登录用户id
            string strJosn = string.Empty;
            var userInfo = HttpContext.User.Claims.FirstOrDefault(hh => hh.Type.Equals("userId"));
            if (userInfo != null)
            {
                int.TryParse(userInfo.Value, out int userId);
                strJosn = await _sysMenuService.GetMenuList(userId);
            }
            return strJosn;
        }
    }
}
