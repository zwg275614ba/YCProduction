using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YCProduction.Common.Extend;
using YCProduction.Model.ViewModel;

namespace YCProduction.BaseEntityFramework.Repository
{
    public class EntityFrameworkCoreRepository<TModel, TKey> : IEntityFrameworkCoreRepository<TModel, TKey>
        where TModel : class, new()
        where TKey : struct
    {
        /// <summary>
        /// 注入DbContext
        /// </summary>
        /// <param name="dbContext"></param>
        public EntityFrameworkCoreRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = dbContext.Set<TModel>();
        }

        public DbSet<TModel> _dbSet;
        private readonly DbContext _dbContext;
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public async Task AddAsync(TModel model)
        {
            await _dbSet.AddAsync(model);
            await Commit();
        }
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="models">实体列表</param>
        /// <returns></returns>
        public async Task AddListAsync(List<TModel> models)
        {
            await _dbSet.AddRangeAsync(models);
            await Commit();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task DeleteAsync(TModel model)
        {
            _dbSet.Remove(model);
            await Commit();
        }
        /// <summary>
        /// 主键删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task DeleteKeyAsync(TKey key)
        {
            var entity = await _dbSet.FindAsync(key);
            if (entity == null)
                throw new Exception("model is null");
            _dbSet.Remove(entity);
            await Commit();
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public async Task DeleteKeyListAsync(List<TKey> keys)
        {
            keys.ForEach(async key =>
            {
                var entity = await _dbSet.FindAsync(key);
                if (entity == null)
                    throw new Exception("model is null");
                _dbSet.Remove(entity);
            });
            await Commit();
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public async Task DeleteListAsync(List<TModel> models)
        {
            _dbSet.RemoveRange(models);
            await Commit();
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateAsync(TModel model)
        {
            _dbContext.Entry<TModel>(model).State = EntityState.Modified;
            await Commit();
        }
        /// <summary>
        /// 自定义更新字段
        /// </summary>
        /// <param name="model">实体</param>
        /// <param name="fields">字段</param>
        /// <returns></returns>
        public async Task UpdateCustomFieldAsync(TModel model, params string[] fields)
        {
            _dbContext.Entry<TModel>(model).State = EntityState.Unchanged;
            if (fields.Length > 0)
            {
                foreach (var field in fields)
                {
                    //标记字段更新
                    _dbContext.Entry<TModel>(model).Property(field).IsModified = true;
                }
            }
            await Commit();
        }
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public async Task UpdateListAsync(List<TModel> models)
        {
            models.ForEach(hh =>
            {
                _dbContext.Entry<TModel>(hh).State = EntityState.Modified;
            });
            await Commit();
        }
        /// <summary>
        /// 获取单个实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<TModel> GetAsync(TKey key)
        {
            return await _dbSet.FindAsync(key);
        }
        /// <summary>
        /// 获取单个实体
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public async Task<TModel> GetAsync(Expression<Func<TModel, bool>> whereLambda)
        {

            return await _dbSet.FirstOrDefaultAsync(whereLambda);
        }
        /// <summary>
        /// 列表
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="whereLambda"></param>
        /// <param name="orderLambda"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public async Task<IList<TModel>> SelectAsync<s>(Expression<Func<TModel, bool>> whereLambda = null, Expression<Func<TModel, s>> orderLambda = null, bool isAsc = true)
        {
            IList<TModel> list;
            if (whereLambda == null)
            {
                list = await _dbSet.ToListAsync();
                return list;
            }
            if (isAsc && orderLambda != null)
                list = await _dbSet.Where(whereLambda).OrderBy(orderLambda).ToListAsync();
            else if (orderLambda != null)
                list = await _dbSet.Where(whereLambda).OrderByDescending(orderLambda).ToListAsync();
            else
                list = await _dbSet.Where(whereLambda).ToListAsync();
            return list;
        }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public async Task<IList<TModel>> SelectAsync(Expression<Func<TModel, bool>> whereLambda = null)
        {
            IList<TModel> list;
            if (whereLambda == null)
            {
                list = await _dbSet.ToListAsync();
                return list;
            }
            list = await _dbSet.Where(whereLambda).ToListAsync();
            return list;
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="whereLambda"></param>
        /// <param name="orderLambda"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public async Task<PagedData<TModel>> SelectPagedAsync<s>(int pageIndex, int pageSize, Expression<Func<TModel, bool>> whereLambda, Expression<Func<TModel, s>> orderLambda, bool isAsc = true)
        {
            var temp = _dbSet.Where(whereLambda);
            var total = temp.Count();
            IQueryable<TModel> pages;
            if (isAsc)
            {
                pages = temp.OrderBy<TModel, s>(orderLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            else
            {
                pages = temp.OrderByDescending<TModel, s>(orderLambda).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            }
            var result = new PagedData<TModel>(pageIndex, pageSize)
            {
                count = total,
                data = pages.ToList(),
            };
            return result;
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="whereLambda"></param>
        /// <param name="orderField"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        public async Task<PagedData<TModel>> SelectPagedAsync(int pageIndex, int pageSize, Expression<Func<TModel, bool>> whereLambda, string orderField, string isAsc = "asc")
        {
            var temp = _dbSet.Where(whereLambda);
            var total = temp.Count();
            IQueryable<TModel> pages;
            if (isAsc.Equals("asc"))
            {
                pages = temp.OrderBy(orderField);
            }
            else
            {
                pages = temp.OrderByDescending(orderField);
            }
            var result = new PagedData<TModel>(pageIndex, pageSize)
            {
                count = total,
                data = await pages.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync()
            };
            return result;
        }
        /// <summary>
        /// sql查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<IList<TModel>> SelectSql(string sql, params MySqlParameter[] parameters)
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
