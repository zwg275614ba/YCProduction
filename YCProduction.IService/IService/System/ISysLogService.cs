using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YCProduction.IService.IBaseService;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.SearchParam.System;
using YCProduction.Model.ViewModel;

namespace YCProduction.IService.IService.System
{
    public interface ISysLogService : IBaseService<SysLog>
    {
        Task<PagedData<SysLog>> LoadUserListPage(LogParam logParam);
    }
}
