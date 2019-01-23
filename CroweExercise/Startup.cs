using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CroweExercise.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CroweExercise
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            // Populate shared data between projects
            var conBlder = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .Build();

            // Now grab individual env values
            SharedData.AppSecrets.CroweExercise_ConnString_SqlServer =  conBlder.GetSection("CroweExercise_ConnString_SqlServer").Value;
            SharedData.AppSecrets.CroweExercise_ConnString_Oracle = conBlder.GetSection("CroweExercise_ConnString_Oracle").Value;
            SharedData.AppSecrets.CroweExercise_Execution_Env = conBlder.GetSection("CroweExercise_Execution_Env").Value;
            //etc.


        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CroweExerciseContext>(opt =>
                opt.UseInMemoryDatabase("TodoList"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
