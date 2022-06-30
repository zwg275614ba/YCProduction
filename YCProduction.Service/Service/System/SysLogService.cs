using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YCProduction.Common.Extend;
using YCProduction.IRepository.IRepository.System;
using YCProduction.IService.IService.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.SearchParam.System;
using YCProduction.Model.ViewModel;
using YCProduction.Service.BaseService;

namespace YCProduction.Service.Service.System
{
    public class SysLogService : BaseService<SysLog>, ISysLogService
    {
        public SysLogService(ISysLogRepository sysLogRepository)
        {
            SysLogRepository = sysLogRepository;
            base.BaseRepository = sysLogRepository;
        }

        public ISysLogRepository SysLogRepository { get; }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="logParam"></param>
        /// <returns></returns>
        public async Task<PagedData<SysLog>> LoadUserListPage(LogParam logParam)
        {
            Expression<Func<SysLog, bool>> expression = ExtLinq.ExpressionTrue<SysLog>();
            if (!string.IsNullOrWhiteSpace(logParam.UserName))
            {
                expression = expression.And<SysLog>(hh => hh.UserName.Contains(logParam.UserName));
            }
            if (logParam.LogType > 0)
            {

            }
            if (!string.IsNullOrEmpty(logParam.StateTime))
            {
                var txt = logParam.StateTime.Replace("+-+", "*");
                var arr = txt.Split('*');
                if (arr.Length > 0)
                {
                    var state = DateTime.Parse(arr[0] + "");
                    var end = DateTime.Parse(arr[1] + "");
                    expression = expression.And(a => a.CreateDate >= state && a.CreateDate <= end.AddDays(1));
                }
            }
            return await SysLogRepository.SelectPagedAsync(logParam.page, logParam.limit, expression, logParam.field, logParam.order);
        }
    }
}
