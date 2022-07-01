using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YCProduction.Common.Extend;
using YCProduction.IRepository.IRepository.Base;
using YCProduction.IService.IService.Base;
using YCProduction.Model.Entitys.Base;
using YCProduction.Model.SearchParam.Base;
using YCProduction.Model.ViewModel;
using YCProduction.Service.BaseService;

namespace YCProduction.Service.Service.Base
{
    public class BaseCustomerInfoService : BaseService<BaseCustomerInfo>, IBaseCustomerInfoService
    {
        public BaseCustomerInfoService(IBaseCustomerInfoRepository baseCustomerInfoRepository)
        {
            base.BaseRepository = baseCustomerInfoRepository;
            BaseCustomerInfoRepository = baseCustomerInfoRepository;
        }

        public IBaseCustomerInfoRepository BaseCustomerInfoRepository { get; }

        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="customerInfoParam"></param>
        /// <returns></returns>
        public async Task<PagedData<BaseCustomerInfo>> LoadUserListPage(CustomerInfoParam customerInfoParam)
        {
            Expression<Func<BaseCustomerInfo, bool>> expression = ExtLinq.ExpressionTrue<BaseCustomerInfo>();
            if (!string.IsNullOrWhiteSpace(customerInfoParam.Contact))
            {
                expression = expression.And(hh => hh.Contact.Contains(customerInfoParam.Contact));
            }
            if (!string.IsNullOrWhiteSpace(customerInfoParam.CustomerCompany))
            {
                expression = expression.And(hh => hh.CustomerCompany.Contains(customerInfoParam.CustomerCompany));
            }
            return await BaseCustomerInfoRepository.SelectPagedAsync(customerInfoParam.page, customerInfoParam.limit, expression, customerInfoParam.field, customerInfoParam.order);
        }
    }
}
