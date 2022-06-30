using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YCProduction.Web.Models;

namespace YCProduction.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["UserName"] = HttpContext.User.Identity.Name;
            ViewData["Photo"] = $"<img src='http://easyadmin.99php.cn/static/admin/images/head.jpg' width='50' height='50' class='layui-nav-img'>";
            return View();
        }
    }
}
