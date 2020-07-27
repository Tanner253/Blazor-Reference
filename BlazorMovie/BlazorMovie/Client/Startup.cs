using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BlazorMovie.Client.Helpers;

namespace BlazorMovie.Client
{
    public class Startup
    {
        public void ConfifureServices(IServiceCollection services)
        {
            services.AddSingleton<SingletonService>();
            services.AddTransient<TransientService>();
            services.AddTransient<IRepository, RepositoryInMemory>();
        }
        //public void Configure(IComponentsApplicationBuilder app)
        //{
        //    app.AddComponent<App>("app");
        //}
    }
}
