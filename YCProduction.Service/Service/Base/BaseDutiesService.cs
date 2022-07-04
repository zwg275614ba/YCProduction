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
    public class BaseDutiesService : BaseService<BaseDuties>, IBaseDutiesService
    {
        public BaseDutiesService(IBaseDutiesRepository baseDutiesRepository)
        {
            BaseRepository = baseDutiesRepository;
            BaseDutiesRepository = baseDutiesRepository;
        }

        public IBaseDutiesRepository BaseDutiesRepository { get; }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="dutiesParam"></param>
        /// <returns></returns>
        public async Task<PagedData<BaseDuties>> LoadUserListPage(DutiesParam dutiesParam)
        {
            Expression<Func<BaseDuties, bool>> expression = ExtLinq.ExpressionTrue<BaseDuties>();
            if (!string.IsNullOrWhiteSpace(dutiesParam.Name))
            {
                expression = expression.And<BaseDuties>(hh => hh.Name.Contains(dutiesParam.Name));
            }
            return await BaseDutiesRepository.SelectPagedAsync(dutiesParam.page, dutiesParam.limit, expression, dutiesParam.field, dutiesParam.order);
        }
    }
}
