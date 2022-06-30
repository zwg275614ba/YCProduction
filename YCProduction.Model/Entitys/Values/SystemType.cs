using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace YCProduction.Model.Entitys.Values
{
    /// <summary>
    /// 用户状态
    /// </summary>
    public enum UserStatus
    {
        [Description("启用")]
        Enable = 0,
        [Description("禁用")]
        Disable = 1
    }
    /// <summary>
    /// 修改密码
    /// </summary>
    public enum UserPwdType
    {
        [Description("允许")]
        Allow = 0,
        [Description("禁止")]
        Ban = 1
    }
    /// <summary>
    /// 角色状态
    /// </summary>
    public enum RoleStatus
    {
        [Description("启用")]
        Enable = 0,
        [Description("禁用")]
        Disable = 1
    }
    /// <summary>
    /// 模块状态
    /// </summary>
    public enum MenuStatus
    {
        [Description("启用")]
        Enable = 0,
        [Description("禁用")]
        Disable = 1
    }
    /// <summary>
    /// 按钮位置
    /// </summary>
    public enum ButtonPosition
    {
        [Description("表单内")]
        InForm = 0,
        [Description("表单外")]
        OutForm = 1
    }
    /// <summary>
    /// 日志类型
    /// </summary>
    public enum DbLogType
    {
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 0,
        /// <summary>
        /// 登录
        /// </summary>
        [Description("登录")]
        Login = 1,
        /// <summary>
        /// 退出
        /// </summary>
        [Description("退出")]
        Exit = 2,
        /// <summary>
        /// 访问
        /// </summary>
        [Description("访问")]
        Visit = 3,
        /// <summary>
        /// 新增
        /// </summary>
        [Description("新增")]
        Create = 4,
        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        Delete = 5,
        /// <summary>
        /// 修改
        /// </summary>
        [Description("修改")]
        Update = 6,
        /// <summary>
        /// 提交
        /// </summary>
        [Description("提交")]
        Submit = 7,
        /// <summary>
        /// 异常
        /// </summary>
        [Description("异常")]
        Exception = 8,
        /// <summary>
        /// 软删除
        /// </summary>
        [Description("软删除")]
        DeleteSoft = 9,
        /// <summary>
        /// 软删除
        /// </summary>
        [Description("SQL语句")]
        SQL = 10,
    }
}
