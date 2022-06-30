
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using YCProduction.BaseEntityFramework.Repository;

namespace YCProduction.Repository.BaseRepository
{
    public class BaseRepository<TModel> : EntityFrameworkCoreRepository<TModel, int>
        where TModel : class, new()
    {
        public BaseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
