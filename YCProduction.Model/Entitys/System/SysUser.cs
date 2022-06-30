using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using YCProduction.Model.Entitys.Values;

namespace YCProduction.Model.Entitys.System
{
    public class SysUser : AggregateRoot
    {
        [DisplayName("账号")]
        public string UserName { get; set; }
        [DisplayName("密码")]
        public string PassWord { get; set; }
        [DisplayName("状态")]
        public UserStatus? Status { get; set; }
        [DisplayName("修改密码")]
        public UserPwdType? IsIsPwd { get; set; }
        [DisplayName("照片")]
        public string PhotoUrl { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}
