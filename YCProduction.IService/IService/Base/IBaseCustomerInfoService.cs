using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YCProduction.IService.IBaseService;
using YCProduction.Model.Entitys.Base;
using YCProduction.Model.SearchParam.Base;
using YCProduction.Model.ViewModel;

namespace YCProduction.IService.IService.Base
{
    public interface IBaseCustomerInfoService : IBaseService<BaseCustomerInfo>
    {
        Task<PagedData<BaseCustomerInfo>> LoadUserListPage(CustomerInfoParam customerInfoParam);
    }
}
