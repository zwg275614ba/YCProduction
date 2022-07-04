using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.IRepository;
using YCProduction.IRepository.IRepository.Base;
using YCProduction.Model.Entitys.Base;
using YCProduction.Repository.BaseRepository;

namespace YCProduction.Repository.Repository.Base
{
    public class BasePositionalTitleRepository : BaseRepository<BasePositionalTitle>, IBasePositionalTitleRepository
    {
        public BasePositionalTitleRepository(YCProductionDBContext dbContext) : base(dbContext)
        {
        }
    }
}
