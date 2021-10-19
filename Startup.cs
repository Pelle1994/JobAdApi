using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceHeroWebApi.Data;
using ServiceHeroWebApi.Interfaces;
using ServiceHeroWebApi.Services;

namespace ServiceHeroWebApi
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
            services.AddControllers();

            services.AddHttpClient("Jobstream", client =>
            {
                client.BaseAddress = new Uri("https://jobstream.api.jobtechdev.se/");
                client.DefaultRequestHeaders.TryAddWithoutValidation("api-key",
                    Configuration.GetSection("Api-Key").Value);
                
            });

            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
            });


            // Dependency Injection
            services.AddScoped<IService, ApiService>();
            services.AddScoped<IMapper, Mapper>();

            //SQL db

            //services.AddDbContext<AdContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("JobAdDb")));


            //SQLite db
            services.AddDbContext<AdContext>(options =>
                options.UseSqlite(@"Data Source="+ Configuration.GetConnectionString("SQLiteAdDb")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "V1.0");

            });
        }
    }
}
