using Autofac;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using YCProduction.IRepository;
using YCProduction.IRepository.IRepository.System;
using YCProduction.Model.ViewModel;
using YCProduction.Repository.Repository.System;

namespace YCProduction.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient(typeof(YCProductionDBContext));
            //services.AddTransient<ISysUserRepository, SysUserRepository>();
            //�����������ݿ��ַ���
            services.AddDbContext<YCProductionDBContext>(options => options.UseMySQL(Configuration.GetConnectionString("MySqlConnectionString")));
            //���ü�Ȩ
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
          .AddCookie(options =>
          {
              //�����Ȩʧ�ܣ�����ת�����·��ȥ��
              options.LoginPath = new PathString("/Account/Index");
          });
            //JSON ȫ������ ����Microsoft.AspNetCore.Mvc.NewtonsoftJson
            services.AddControllersWithViews().AddNewtonsoftJson(options =>
            {
                //���ݸ�ʽ��ԭ�����  --��ѡ���Ĭ��������� 
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
            services.Configure<SysAdminLoginConfig>(Configuration.GetSection("Login")) ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            //��Ȩ
            app.UseAuthentication();
            //��Ȩ
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //ע������·��
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }


        public void ConfigureContainer(ContainerBuilder container)
        {
            {
                //ע�����ݲ�
                var assemblyRepository = Assembly.Load("YCProduction.Repository");
                container.RegisterTypes(assemblyRepository.GetTypes()).AsImplementedInterfaces();
                //ע��ҵ���
                var assemblyService = Assembly.Load("YCProduction.Service");
                container.RegisterTypes(assemblyService.GetTypes()).AsImplementedInterfaces();
            }
        }
    }
}
