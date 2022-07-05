using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YCProduction.Common.Extend;
using YCProduction.IRepository.IRepository.Dictionary;
using YCProduction.IService.IService.Dictionary;
using YCProduction.Model.Entitys.Dictionary;
using YCProduction.Model.SearchParam.Dictionary;
using YCProduction.Model.ViewModel;
using YCProduction.Service.BaseService;

namespace YCProduction.Service.Service.Dictionary
{
    public class DicIndustryCategoryService : BaseService<DicIndustryCategory>, IDicIndustryCategoryService
    {
        public DicIndustryCategoryService(IDicIndustryCategoryRepository dicIndustryCategoryRepository)
        {
            DicIndustryCategoryRepository = dicIndustryCategoryRepository;
            base.BaseRepository = dicIndustryCategoryRepository;
        }

        public IDicIndustryCategoryRepository DicIndustryCategoryRepository { get; }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="industryCategoryParam"></param>
        /// <returns></returns>
        public async Task<PagedData<DicIndustryCategory>> LoadListPage(IndustryCategoryParam industryCategoryParam)
        {
            Expression<Func<DicIndustryCategory, bool>> expression = ExtLinq.ExpressionTrue<DicIndustryCategory>();
            if (!string.IsNullOrWhiteSpace(industryCategoryParam.IndustryCategory))
            {
                expression = expression.And<DicIndustryCategory>(hh => hh.IndustryCategory.Contains(industryCategoryParam.IndustryCategory));
            }
            return await DicIndustryCategoryRepository.SelectPagedAsync(industryCategoryParam.page, industryCategoryParam.limit, expression, industryCategoryParam.field, industryCategoryParam.order);
        }
    }
}
