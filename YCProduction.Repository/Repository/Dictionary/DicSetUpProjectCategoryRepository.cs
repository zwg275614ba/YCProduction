using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.IRepository;
using YCProduction.IRepository.IRepository.Dictionary;
using YCProduction.Model.Entitys.Dictionary;
using YCProduction.Repository.BaseRepository;

namespace YCProduction.Repository.Repository.Dictionary
{
    public class DicSetUpProjectCategoryRepository : BaseRepository<DicSetUpProjectCategory>, IDicSetUpProjectCategoryRepository
    {
        public DicSetUpProjectCategoryRepository(YCProductionDBContext dbContext) : base(dbContext)
        {
        }
    }
}
