using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YCProduction.IRepository.BaseRepository;
using YCProduction.IService.IBaseService;
using YCProduction.Model.ViewModel;

namespace YCProduction.Service.BaseService
{
    public class BaseService<TModel> : IBaseService<TModel> where TModel : class, new()
    {
        protected IBaseRepository<TModel> BaseRepository { get; set; }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task AddAsync(TModel model)
        {
            await BaseRepository.AddAsync(model);
        }
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public async Task AddListAsync(List<TModel> models)
        {
            await BaseRepository.AddListAsync(models);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task DeleteAsync(TModel model)
        {
            await BaseRepository.DeleteAsync(model);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task DeleteKeyAsync(int key)
        {
            await BaseRepository.DeleteKeyAsync(key);
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        public async Task DeleteKeyListAsync(List<int> keys)
        {
            await BaseRepository.DeleteKeyListAsync(keys);
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public async Task DeleteListAsync(List<TModel> models)
        {
            await BaseRepository.DeleteListAsync(models);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task UpdateAsync(TModel model)
        {
            await BaseRepository.UpdateAsync(model);
        }
        /// <summary>
        /// 更新字段
        /// </summary>
        /// <param name="model"></param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public async Task UpdateCustomFieldAsync(TModel model, params string[] fields)
        {
            await BaseRepository.UpdateCustomFieldAsync(model, fields);
        }
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        public async Task UpdateListAsync(List<TModel> models)
        {
            await BaseRepository.UpdateListAsync(models);
        }
        /// <summary>
        /// 获取单个实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<TModel> GetAsync(int key)
        {
            return await BaseRepository.GetAsync(key);
        }
        /// <summary>
        /// 获取单个实体
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public async Task<TModel> GetAsync(Expression<Func<TModel, bool>> whereLambda)
        {
            return await BaseRepository.GetAsync(whereLambda);
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
            return await BaseRepository.SelectAsync(whereLambda, orderLambda, isAsc);
        }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public async Task<IList<TModel>> SelectAsync(Expression<Func<TModel, bool>> whereLambda = null)
        {
            return await BaseRepository.SelectAsync(whereLambda);
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">显示行数</param>
        /// <param name="whereLambda">条件</param>
        /// <param name="orderLambda">排序</param>
        /// <param name="isAsc">默认升序</param>
        /// <returns></returns>
        public async Task<PagedData<TModel>> SelectPagedAsync<s>(int pageIndex, int pageSize, Expression<Func<TModel, bool>> whereLambda, Expression<Func<TModel, s>> orderLambda, bool isAsc = true)
        {
            return await BaseRepository.SelectPagedAsync(pageIndex, pageSize, whereLambda, orderLambda, isAsc);
        }
        /// <summary>
        /// sql 查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Task<IList<TModel>> SelectSql(string sql, params MySqlParameter[] parameters)
        {
            return BaseRepository.SelectSql(sql, parameters);
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
            return await BaseRepository.SelectPagedAsync(pageIndex, pageSize, whereLambda, orderField, isAsc);
        }
    }
}
