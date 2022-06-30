using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YCProduction.Model.ViewModel
{
    /// <summary>
    /// 修改密码实体
    /// </summary>
    public class ModifyPwdEntity
    {
        [Display(Name = "原密码")]
        public string OldPassword { get; set; }
        [Display(Name = "新密码")]
        public string NewPassword { get; set; }
        [Display(Name = "确认密码")]
        public string ConfirmPassword { get; set; }
    }
}
