using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using QL.WebAPI.Models;
using QL.Core.Data;
using QL.Data.EntityFramework;
using Microsoft.EntityFrameworkCore;
using QL.Data.EntityFramework.Repositories;
using GraphQL;
using GraphQL.Types;
using AutoMapper;

namespace QL.WebAPI
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
            services.AddMvc();
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<QLQuery>();
            services.AddScoped<QLMutation>();
            services.AddTransient<IDroidRepository, DroidRepository>();
            services.AddTransient<IFriendRepository, FriendRepository>();
            services.AddDbContext<QLContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IDocumentExecuter,DocumentExecuter>();
            services.AddTransient<DroidType>();
            services.AddTransient<DroidInputType>();
            services.AddTransient<FriendType>();
            services.AddTransient<FriendSexEnum>();
            var sp = services.BuildServiceProvider();
            services.AddScoped<ISchema>(_ => new QLSchema(type => (GraphType)sp.GetService(type)) { Query = sp.GetService<QLQuery>(),Mutation = sp.GetService<QLMutation>() });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
