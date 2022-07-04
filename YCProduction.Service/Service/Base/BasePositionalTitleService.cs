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
    public class BasePositionalTitleService : BaseService<BasePositionalTitle>, IBasePositionalTitleService
    {
        public BasePositionalTitleService(IBasePositionalTitleRepository basePositionalTitleRepository)
        {
            base.BaseRepository = basePositionalTitleRepository;
            BasePositionalTitleRepository = basePositionalTitleRepository;
        }

        public IBasePositionalTitleRepository BasePositionalTitleRepository { get; }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="positionalTitleParam"></param>
        /// <returns></returns>
        public async Task<PagedData<BasePositionalTitle>> LoadUserListPage(PositionalTitleParam positionalTitleParam)
        {
            Expression<Func<BasePositionalTitle, bool>> expression = ExtLinq.ExpressionTrue<BasePositionalTitle>();
            if (!string.IsNullOrWhiteSpace(positionalTitleParam.Name))
            {
                expression = expression.And<BasePositionalTitle>(hh => hh.Name.Contains(positionalTitleParam.Name));
            }
            return await BasePositionalTitleRepository.SelectPagedAsync(positionalTitleParam.page, positionalTitleParam.limit, expression, positionalTitleParam.field, positionalTitleParam.order);
        }
    }
}
