using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace YCProduction.IRepository
{
    public class YCProductionDBContext : DbContext
    {
        readonly string _connStr;
        public YCProductionDBContext(string connectionString)
        {
            _connStr = connectionString;
        }

        public YCProductionDBContext(DbContextOptions<YCProductionDBContext> options)
            : base(options)
        {
        }
        /// <summary>
        /// 配置链接数据库
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(_connStr);
            }
            //optionsBuilder.UseMySQL("server=localhost;database=yc_production;uid=root;pwd=sasa;charset='utf8';SslMode=None");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
