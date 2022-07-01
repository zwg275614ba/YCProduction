using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YCProduction.Common.ClientApi;
using YCProduction.Common.CryptHelper;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.Entitys.Values;
using YCProduction.Model.SearchParam.System;
using YCProduction.Model.ViewModel;
using YCProduction.Web.Controllers;


namespace YCProduction.Web.Areas.System.Controllers
{
    [Area("System")]
    public class UserController : BaseController
    {
        private readonly ISysUserService _sysUserService;
        private readonly ISysUserRoleService _sysUserRoleService;
        private readonly ISysRoleService _sysRoleService;

        public UserController(
            ISysUserService sysUserService,
            ISysUserRoleService sysUserRoleService,
            ISysActionService sysActionService,
            ISysRoleService sysRoleService)
            : base(sysUserRoleService, sysActionService)
        {
            this._sysUserService = sysUserService;
            this._sysUserRoleService = sysUserRoleService;
            this._sysRoleService = sysRoleService;
        }

        #region 列表
        [HttpGet]
        public async Task<IActionResult> GetUserList(UserParam userParam)
        {
            return Json(await _sysUserService.LoadUserListPage(userParam));
        }
        #endregion

        #region 添加
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddInfo(SysUser model)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            #region 验证输入的账号是否存在
            var list = await _sysUserService.SelectAsync(h => h.UserName == model.UserName);
            if (list.Count > 0)
            {
                ajaxResult.Message = "账号已存在";
                return Json(ajaxResult);
            }
            #endregion
            model.Status = UserStatus.Enable;
            model.IsIsPwd = UserPwdType.Allow;
            model.CreateDate = DateTime.Now;
            model.PassWord = Md5Crypt.Encrypt(model.PassWord);
            await _sysUserService.AddAsync(model);
            ajaxResult.State = true;
            ajaxResult.Message = "操作成功";
            return Json(ajaxResult);
        }
        #endregion

        #region 删除
        [HttpPost]
        public async Task<IActionResult> DelInfo(int id)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            var userEntity = await _sysUserService.GetAsync(h => h.Id == id);
            if (userEntity != null && userEntity.Id > 0)
            {
                await _sysUserService.DeleteAsync(userEntity);
                ajaxResult.State = true;
                ajaxResult.Message = "操作成功";
            }
            return Json(ajaxResult);
        }
        #endregion

        #region 重置密码
        [HttpPost]
        public async Task<IActionResult> ResetPwd(int id)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            var userEntity = await _sysUserService.GetAsync(h => h.Id == id);
            if (userEntity != null && userEntity.Id > 0)
            {
                userEntity.PassWord = Md5Crypt.Encrypt("a123456");
                await _sysUserService.UpdateAsync(userEntity);
                ajaxResult.State = true;
                ajaxResult.Message = "重置密码成功,新密码为【a123456】";
            }
            return Json(ajaxResult);
        }
        #endregion

        #region 分配角色
        [HttpGet]
        public async Task<IActionResult> AllotRole(int id)
        {
            //获取用户对于角色
            var list = await _sysUserRoleService.SelectAsync(h => h.UserId == id);
            var roleList = list.AsQueryable().Select(h => h.RoleId).ToList();
            StringBuilder sb = new StringBuilder();
            var rolelist = await _sysRoleService.SelectAsync();
            if (rolelist.Count > 0)
            {
                foreach (var item in rolelist)
                {
                    sb.Append(string.Format("<input type=\"checkbox\" name=\"ids\" lay-skin=\"primary\" title='{0}' value='{1}'", item.RoleName, item.Id));
                    if (roleList.Contains(item.Id))
                    {
                        sb.Append("checked>");
                    }
                    else
                    {
                        sb.Append(">");
                    }
                }
            }
            ViewBag.RoleNames = sb.ToString();
            ViewBag.UserId = id;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AllotRole(int userId, string ids)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            if (userId > 0)
            {
                //删除原用户原角色
                var oldRoleList = await _sysUserRoleService.SelectAsync(h => h.UserId == userId);
                if (oldRoleList.Count > 0)
                {
                    foreach (var item in oldRoleList)
                    {
                        int.TryParse(item.Id + "", out int id);
                        var entity = await _sysUserRoleService.GetAsync(h => h.Id == id);
                        await _sysUserRoleService.DeleteAsync(entity);
                    }
                }
                //分配用户角色
                string[] strArr = ids.Split(',');
                if (strArr.Length > 0)
                {
                    for (int i = 0; i < strArr.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(strArr[i].Trim()))
                        {
                            SysUserRole model = new SysUserRole
                            {
                                UserId = userId,
                                RoleId = int.Parse(strArr[i].ToString())
                            };
                            await _sysUserRoleService.AddAsync(model);
                        }
                    }
                }
                ajaxResult.State = true;
                ajaxResult.Message = "操作成功";
            }
            return Json(ajaxResult);
        }
        #endregion

        #region 是否登录
        [HttpPost]
        public async Task<IActionResult> IsState(int Id, int State)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            var userEntity = await _sysUserService.GetAsync(h => h.Id == Id);
            if (userEntity != null)
            {
                userEntity.Status = State == 1 ? UserStatus.Disable : UserStatus.Enable;
                await _sysUserService.UpdateAsync(userEntity);
                ajaxResult.State = true;
                ajaxResult.Message = "操作成功";
            }
            return Json(ajaxResult);
        }
        #endregion

        #region 是否改密
        [HttpPost]
        public async Task<IActionResult> IsPwd(int Id, int IsPwd)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "操作失败";
            var userEntity = await _sysUserService.GetAsync(h => h.Id == Id);
            if (userEntity != null)
            {
                userEntity.IsIsPwd = IsPwd == 1 ? UserPwdType.Ban : UserPwdType.Allow;
                await _sysUserService.UpdateAsync(userEntity);
                ajaxResult.State = true;
                ajaxResult.Message = "操作成功";
            }
            return Json(ajaxResult);
        }
        #endregion

        #region 修改个人密码
        [HttpGet]
        public ActionResult EditPwd()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EditPwd(ModifyPwdEntity model)
        {
            AjaxResult ajaxResult = new AjaxResult();
            ajaxResult.State = false;
            ajaxResult.Message = "修改密码失败";
            int userId = LoginUserId;
            var userEntity = await _sysUserService.GetAsync(h => h.Id == userId);
            if (userEntity != null && userEntity.Id > 0)
            {
                //验证输入的原密码是否正确
                if (!userEntity.PassWord.Equals(Md5Crypt.Encrypt(model.OldPassword)))
                {
                    ajaxResult.Message = "输入的原密码错误";
                    return Json(ajaxResult);
                }
                //验证输入的新密码是否为原密码
                if (userEntity.PassWord.Equals(Md5Crypt.Encrypt(model.NewPassword)))
                {
                    ajaxResult.Message = "新密码不能与原密码一致";
                    return Json(ajaxResult);
                }
                //修改密码
                userEntity.PassWord = Md5Crypt.Encrypt(model.NewPassword);
                await _sysUserService.UpdateAsync(userEntity);
                ajaxResult.State = true;
                ajaxResult.Message = "密码修改成功,请重新登录";
            }
            return Json(ajaxResult);
        }

        #endregion
    }
}
