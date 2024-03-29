using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ProAdm.Application;
using ProAdm.Application.Constracts;
using ProAdm.Persistence;
using ProAdm.Persistence.Contexts;
using ProAdm.Persistence.Contracts;

namespace ProAdm.API
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
            services.AddDbContext<ProAdmContext>(
               context => context.UseSqlite(Configuration.GetConnectionString("Default"))  
            );
            services.AddControllers();
            services.AddScoped<IAbastecimentoService,AbastecimentoService>();
            services.AddScoped<IAbastecimentoPersist,AbastecimentoPersist>();

            services.AddScoped<IViaturaService,ViaturaService>();
            services.AddScoped<IViaturaPersist,ViaturaPersist>();

            services.AddScoped<IServidorService,ServidorService>();
            services.AddScoped<IServidorPersist,ServidorPersist>();

            services.AddScoped<IGeneralPersist,GeneralPersist>();
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProAdm.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProAdm.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(
                x => x.AllowAnyHeader()
                      .AllowAnyMethod()
                      .AllowAnyOrigin()
            );
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
