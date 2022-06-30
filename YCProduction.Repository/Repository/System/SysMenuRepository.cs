using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YCProduction.IRepository;
using YCProduction.IRepository.IRepository.System;
using YCProduction.Model.Entitys.System;
using YCProduction.Model.Entitys.Values;
using YCProduction.Repository.BaseRepository;

namespace YCProduction.Repository.Repository.System
{
    public class SysMenuRepository : BaseRepository<SysMenu>, ISysMenuRepository
    {
        private DbContext db;
        public SysMenuRepository(YCProductionDBContext dbContext) : base(dbContext)
        {
            db = dbContext;
        }

        /// <summary>
        /// 获取登录用户菜单
        /// </summary>
        /// <param name="userId">登录用户id</param>
        /// <returns>返回登录用户对应菜单</returns>
        public async Task<string> GetMenuList(int userId)
        {
            string strJson = string.Empty;
            //获取用户登录名
            var userEntity = await db.Set<SysUser>().FirstOrDefaultAsync(h => h.Id == userId);
            var userName = userEntity.UserName;
            var adm = "admin";
            List<SysMenu> myList = new List<SysMenu>();
            IEnumerable<SysMenu> list;
            if (adm.Equals(userName))
            {
                //管理员用户获取所有菜单
                list = from j in db.Set<SysMenu>() select j;
                myList = list.ToList();
                //一级目录
                var list_1 = myList.Where(h => h.MenuLevel == 1);
                foreach (var item in list_1)
                {
                    //二级栏目
                    List<SysMenu> list_2 = null;
                    try
                    {
                        list_2 = myList.Where(h => h.ParentId == item.Id).ToList();
                    }
                    catch (Exception ex)
                    {


                    }
                    foreach (var n in list_2)
                    {
                        //去除无子集的二级栏目
                        if (list.Count(q => q.ParentId == n.Id) == 0)
                        {
                            myList = myList.Except(from o in myList where o.Id == n.Id select o).ToList();
                        }
                    }
                }
                foreach (var m in list_1)
                {
                    //去除无子集的一级栏目
                    if (myList.Count(q => q.ParentId == m.Id) == 0)
                    {
                        myList = myList.Except(from o in myList where o.Id == m.Id select o).ToList();
                    }
                }
                strJson = GetMenu(myList);
            }
            else //普通用户
            {
                var menuList = from c in db.Set<SysMenu>() where ((from b in db.Set<SysRoleMenuAction>() where (from a in db.Set<SysUserRole>() where a.UserId == userId select a.RoleId).Contains(b.RoleId) select b.MenuId).Distinct()).Contains(c.Id) && c.Status == MenuStatus.Enable select c;
                if (menuList.Count() > 0)
                {
                    //获取一级二级目录
                    var _list = from d in db.Set<SysMenu>().Where(h => h.MenuLevel <= 2) select d;
                    //一级二级三级目录合并
                    list = menuList.Union(_list);
                    myList = list.ToList();
                    //一级目录
                    var list_1 = list.Where(h => h.MenuLevel == 1);
                    foreach (var item in list_1)
                    {
                        //二级栏目
                        var list_2 = list.Where(h => h.ParentId == item.Id).ToList();
                        foreach (var n in list_2)
                        {
                            //去除无子集的二级栏目
                            if (list.Count(q => q.ParentId == n.Id) == 0)
                            {
                                myList = myList.Except(from o in list where o.Id == n.Id select o).ToList();
                            }
                        }
                    }
                    foreach (var m in list_1)
                    {
                        //去除无子集的一级栏目
                        if (myList.Count(q => q.ParentId == m.Id) == 0)
                        {
                            myList = myList.Except(from o in list where o.Id == m.Id select o).ToList();
                        }
                    }

                    strJson = GetMenu(myList);
                }
                else
                {
                    strJson = "";
                }
            }
            return strJson;
        }

        /// <summary>
        /// 拼接json 
        /// </summary>
        /// <returns></returns>
        public string GetMenu(List<SysMenu> lst)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"menuInfo\":{");
            if (lst.Count > 0)
            {
                //排序
                lst = lst.OrderBy(h => h.OrderNo).ToList();
                //获取一级菜单
                var list_1 = lst.Where(h => h.MenuLevel == 1).ToList();
                for (int i = 0; i < list_1.Count; i++)
                {
                    sb.Append("\"currency" + i + "\":");
                    sb.Append("{ \"title\":\"" + list_1[i].MenuName + "\",\"icon\":\"fa " + list_1[i].MenuIccon + "\",\"child\":[");
                    //获取二级菜单
                    var list_2 = lst.Where(h => h.ParentId == list_1[i].Id).ToList();
                    foreach (var item2 in list_2)
                    {

                        sb.Append("{\"title\":\"" + item2.MenuName + "\",\"href\":\"\",\"icon\":\"fa " + item2.MenuIccon + "\",\"target\":\"_self\",\"child\":[");
                        //获取三级菜单
                        var list_3 = lst.Where(h => h.ParentId == item2.Id).ToList();
                        foreach (var item3 in list_3)
                        {
                            sb.Append(" {\"title\":\"" + item3.MenuName + "\",\"href\":\"" + item3.MenuUrl + "\",\"icon\":\"fa " + item3.MenuIccon + "\",\"menuId\":\"" + item3.Id + "\", \"target\":\"_self\"},");
                        }
                        sb.Remove(sb.Length - 1, 1);
                        sb.Append("]},");
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append("]},");
                }
                sb.Remove(sb.Length - 1, 1);
            }
            sb.Append("}}");
            return sb.ToString();
        }
    }
}
