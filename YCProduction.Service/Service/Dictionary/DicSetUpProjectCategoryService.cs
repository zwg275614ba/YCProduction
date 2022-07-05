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
    public class DicSetUpProjectCategoryService : BaseService<DicSetUpProjectCategory>, IDicSetUpProjectCategoryService
    {
        public DicSetUpProjectCategoryService(IDicSetUpProjectCategoryRepository dicSetUpProjectCategoryRepository)
        {
            DicSetUpProjectCategoryRepository = dicSetUpProjectCategoryRepository;
            base.BaseRepository = dicSetUpProjectCategoryRepository;
        }

        public IDicSetUpProjectCategoryRepository DicSetUpProjectCategoryRepository { get; }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="projectCategoryParam"></param>
        /// <returns></returns>
        public async Task<PagedData<DicSetUpProjectCategory>> LoadListPage(SetUpProjectCategoryParam projectCategoryParam)
        {
            Expression<Func<DicSetUpProjectCategory, bool>> expression = ExtLinq.ExpressionTrue<DicSetUpProjectCategory>();
            if (!string.IsNullOrWhiteSpace(projectCategoryParam.Category))
            {
                expression = expression.And<DicSetUpProjectCategory>(hh => hh.Category.Contains(projectCategoryParam.Category));
            }
            return await DicSetUpProjectCategoryRepository.SelectPagedAsync(projectCategoryParam.page, projectCategoryParam.limit, expression, projectCategoryParam.field, projectCategoryParam.order);
        }
    }
}
