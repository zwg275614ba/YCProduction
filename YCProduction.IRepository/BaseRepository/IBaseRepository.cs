using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.BaseEntityFramework.Repository;

namespace YCProduction.IRepository.BaseRepository
{
    public interface IBaseRepository<TModel> : IEntityFrameworkCoreRepository<TModel, int>
         where TModel : class, new()
    {
    }
}
