using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;

namespace SGA.WebApiGestaoAtivo
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            Configuration = configuration;
            HostingEnvironment = environment;
        }

        public IConfiguration Configuration { get; }
        public IHostingEnvironment HostingEnvironment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "Gestão de Ativos API",
                    Version = "v1",
                    Description = "Módulo de Gestão de Ativos API - SGA",
                });
            });

            services.Configure<Settings>(
            options =>
            {
                options.ConnectionString = Configuration.GetSection("MongoDb:ConnectionString").Value;
                options.Database = Configuration.GetSection("MongoDb:Database").Value;
                options.Container = Configuration.GetSection("MongoDb:Container").Value;
                options.IsContained = Configuration["DOTNET_RUNNING_IN_CONTAINER"] != null;
                options.Development = HostingEnvironment.IsDevelopment();
            });

            services.AddTransient<Contexto.IApplicationDbContext, Contexto.ApplicationDbContext>();
            services.AddTransient<Contexto.Replository.IAtivoRepository, Contexto.Replository.AtivoRepository>();
            services.AddTransient<Contexto.Replository.ISolicitacaoCompraAtivoRepository, Contexto.Replository.SolicitacaoCompraAtivoRepository>();

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gestão de Ativos API v1");
            });

        }
    }
}
