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
    public class DicProjectCategoryService : BaseService<DicProjectCategory>, IDicProjectCategoryService
    {
        public DicProjectCategoryService(IDicProjectCategoryRepository dicProjectCategoryRepository)
        {
            DicProjectCategoryRepository = dicProjectCategoryRepository;
            base.BaseRepository = dicProjectCategoryRepository;
        }

        public IDicProjectCategoryRepository DicProjectCategoryRepository { get; }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="projectCategoryParam"></param>
        /// <returns></returns>
        public async Task<PagedData<DicProjectCategory>> LoadListPage(ProjectCategoryParam projectCategoryParam)
        {
            Expression<Func<DicProjectCategory, bool>> expression = ExtLinq.ExpressionTrue<DicProjectCategory>();
            if (!string.IsNullOrWhiteSpace(projectCategoryParam.ProjectCategory))
            {
                expression = expression.And<DicProjectCategory>(hh => hh.ProjectCategory.Contains(projectCategoryParam.ProjectCategory));
            }
            return await DicProjectCategoryRepository.SelectPagedAsync(projectCategoryParam.page, projectCategoryParam.limit, expression, projectCategoryParam.field, projectCategoryParam.order);
        }
    }
}
