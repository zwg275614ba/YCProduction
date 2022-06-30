using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YCProduction.Model.ViewModel;

namespace YCProduction.IService.IBaseService
{
    public interface IBaseService<TModel> where TModel : class, new()
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        Task AddAsync(TModel model);
        /// <summary>
        /// 批量添加
        /// </summary>
        /// <param name="models">实体列表</param>
        /// <returns></returns>
        Task AddListAsync(List<TModel> models);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        Task UpdateAsync(TModel model);
        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="models">实体列表</param>
        /// <returns></returns>
        Task UpdateListAsync(List<TModel> models);
        /// <summary>
        /// 更新自定义字段
        /// </summary>
        /// <param name="model">实体</param>
        /// <param name="fields">更新字段</param>
        /// <returns></returns>
        Task UpdateCustomFieldAsync(TModel model, params string[] fields);
        /// <summary>
        /// 主键删除
        /// </summary>
        /// <param name="key">主键值</param>
        /// <returns></returns>
        Task DeleteKeyAsync(int key);
        /// <summary>
        /// 主键批量删除
        /// </summary>
        /// <param name="keys"></param>
        /// <returns></returns>
        Task DeleteKeyListAsync(List<int> keys);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task DeleteAsync(TModel model);
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="models"></param>
        /// <returns></returns>
        Task DeleteListAsync(List<TModel> models);
        /// <summary>
        /// 通过id获取实体
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<TModel> GetAsync(int key);
        /// <summary>
        /// 获取单个实体对象
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        Task<TModel> GetAsync(Expression<Func<TModel, bool>> whereLambda);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <typeparam name="s"></typeparam>
        /// <param name="whereLambda"></param>
        /// <param name="orderLambda"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        Task<IList<TModel>> SelectAsync<s>(Expression<Func<TModel, bool>> whereLambda = null, Expression<Func<TModel, s>> orderLambda = null, bool isAsc = true);
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        Task<IList<TModel>> SelectAsync(Expression<Func<TModel, bool>> whereLambda = null);
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
        Task<PagedData<TModel>> SelectPagedAsync<s>(int pageIndex, int pageSize, Expression<Func<TModel, bool>> whereLambda, Expression<Func<TModel, s>> orderLambda, bool isAsc = true);
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="whereLambda"></param>
        /// <param name="orderField"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        Task<PagedData<TModel>> SelectPagedAsync(int pageIndex, int pageSize, Expression<Func<TModel, bool>> whereLambda, string orderField, string isAsc = "asc");
        /// <summary>
        /// sql查询
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        Task<IList<TModel>> SelectSql(string sql, params MySqlParameter[] parameters);
    }
}
