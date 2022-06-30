using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using YCProduction.Common.Cache;
using YCProduction.Common.ClientApi;
using YCProduction.Common.CryptHelper;
using YCProduction.IRepository.IRepository.System;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.Entitys.Values;
using YCProduction.Model.ViewModel;

namespace YCProduction.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ISysUserService _sysUserService;
        private readonly IOptions<SysAdminLoginConfig> _options;

        public AccountController(ISysUserService sysUserService, IOptions<SysAdminLoginConfig> options)
        {
            this._sysUserService = sysUserService;
            this._options = options;
        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sysUser"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Login(SysUser sysUser)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "登录失败";
            if (!string.IsNullOrWhiteSpace(sysUser.UserName) && !string.IsNullOrWhiteSpace(sysUser.PassWord))
            {
                //检测用户登录次数
                SysAdminLoginConfig sysAdminLoginConfig = MemoryCacheHelper.Get<SysAdminLoginConfig>(sysUser.UserName);
                if (sysAdminLoginConfig != null)
                {
                    //错误次数大于允许错误值
                    if (sysAdminLoginConfig.ErrorCount >= _options.Value.Count)
                    {
                        ajaxResult.Message = "您的登录以超过设定次数，请稍后再次登录~";
                        return Json(ajaxResult);
                    }
                }
                else
                {
                    MemoryCacheHelper.Set(sysUser.UserName, new SysAdminLoginConfig { ErrorCount = 0, AccountName = sysUser.UserName });
                }

                var user = await _sysUserService.GetAsync(hh => hh.UserName.Equals(sysUser.UserName) && hh.PassWord.Equals(Md5Crypt.Encrypt(sysUser.PassWord)));
                if (user != null)
                {
                    //验证用户是否允许登录
                    if (user.Status == UserStatus.Disable)
                    {
                        ajaxResult.Message = "该账号禁止登录,请联系管理员开通登录权限";
                    }
                    else
                    {
                        //保存用户登录信息
                        var claims = new List<Claim>()//鉴别你是谁，相关信息
                         {
                        new Claim(ClaimTypes.Name,user.UserName),
                        new Claim("userId",user.Id+"")
                        };
                        //ClaimsPrincipal 用户信息打包，写入到一个身份证中去
                        ClaimsPrincipal userPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claims, "Customer")); //针对与当前用户的身份证                        
                        //登录//把身份证信息保存到Cookies中
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, new AuthenticationProperties
                        {
                            ExpiresUtc = DateTime.UtcNow.AddMinutes(30),//过期时间：30分钟
                        });
                        ajaxResult.State = true;
                        ajaxResult.Message = "登录成功,正在跳转";
                    }
                }
                else
                {
                    var sysAdminLoginConfig2 = MemoryCacheHelper.Get<SysAdminLoginConfig>(sysUser.UserName);
                    sysAdminLoginConfig2.ErrorCount += 1;
                    ajaxResult.Message = "输入账号错误,您还剩余" + (_options.Value.Count - sysAdminLoginConfig2.ErrorCount) + "登录次数";
                    MemoryCacheHelper.Set(sysUser.UserName, new SysAdminLoginConfig { ErrorCount = sysAdminLoginConfig2.ErrorCount, AccountName = sysUser.UserName }, _options.Value.DelayMinute);
                    //输入错误次数达到最大值
                    if (sysAdminLoginConfig2.ErrorCount == _options.Value.Count)
                    {
                        ajaxResult.Message = $"登录次数超过{_options.Value.Count}" + "次，请" + _options.Value.DelayMinute + "分钟后再次登录";
                    }
                }
            }
            return Json(ajaxResult);
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult OutLogin()
        {
            HttpContext.SignOutAsync();
            return Redirect("/Account");
        }
    }
}
