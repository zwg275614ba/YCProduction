using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YCProduction.IService.IBaseService;
using YCProduction.Model.Entitys.Dictionary;
using YCProduction.Model.SearchParam.Dictionary;
using YCProduction.Model.ViewModel;

namespace YCProduction.IService.IService.Dictionary
{
    public interface IDicIndustryCategoryService : IBaseService<DicIndustryCategory>
    {
        Task<PagedData<DicIndustryCategory>> LoadListPage(IndustryCategoryParam industryCategoryParam);
    }
}
