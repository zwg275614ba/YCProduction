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
    public class DicProjectResultService : BaseService<DicProjectResult>, IDicProjectResultService
    {
        public DicProjectResultService(IDicProjectResultRepository dicProjectResultRepository)
        {
            base.BaseRepository = dicProjectResultRepository;
            DicProjectResultRepository = dicProjectResultRepository;
        }

        public IDicProjectResultRepository DicProjectResultRepository { get; }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="projectResultParam"></param>
        /// <returns></returns>

        public async Task<PagedData<DicProjectResult>> LoadListPage(ProjectResultParam projectResultParam)
        {
            Expression<Func<DicProjectResult, bool>> expression = ExtLinq.ExpressionTrue<DicProjectResult>();
            if (!string.IsNullOrWhiteSpace(projectResultParam.Result))
            {
                expression = expression.And<DicProjectResult>(hh => hh.Result.Contains(projectResultParam.Result));
            }
            return await DicProjectResultRepository.SelectPagedAsync(projectResultParam.page, projectResultParam.limit, expression, projectResultParam.field, projectResultParam.order);
        }
    }
}
