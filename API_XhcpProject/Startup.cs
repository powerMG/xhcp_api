using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using Xhcp_DAL;
using Xhcp_Service;
using Xhcp_Service.ProductService;

namespace API_XhcpProject
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
            var connection = Configuration.GetConnectionString("MySqlConnection");
            services.AddDbContext<ProductContext>(a => a.UseMySql(connection));
            services.AddUnitOfWork<ProductContext>();//添加UnitOfWork支持
            services.AddScoped(typeof(IProductService), typeof(ProductService));//用ASP.NET Core自带依赖注入(DI)注入使用的类
            //将Redis分布式缓存服务添加到服务中
            services.AddDistributedRedisCache(c =>
            {
                //用于连接Redis的配置  Configuration.GetConnectionString("RedisConnectionString")读取配置信息的串
                c.Configuration = Configuration.GetConnectionString("RedisConnection");
                //Redis实例名RedisDistributedCache
                c.InstanceName = "RedisDistributedCache";
            });
            services.AddMvc();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Xhcp_api", Version = "V1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                //c.SwaggerEndpoint("/swagger/v1/swagger.json", "Xhcp_Api V1");
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Xhcp API V1");
                //加载汉化的js文件，注意 swagger.js文件属性必须设置为“嵌入的资源”。
                //c.InjectOnCompleteJavaScript("/Scripts/swagger.js");
            });
            app.UseMvc();
        }
    }
}
