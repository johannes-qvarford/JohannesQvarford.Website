using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JohannesQvarford.Website
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddMvc();

            // services.Configure<RazorViewEngineOptions>(opt => {
            //     opt.ViewLocationExpanders.Add(new LocalizationViewLocationExpander());
            // });

            // services.AddTransient<IConfigureOptions<MvcViewOptions>, LocalizationViewOptionsSetup>();
            // services.AddSingleton<LocalizationViewEngine>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "Projects", 
                    template: "{language=en}/projects/{title}",
                    defaults: new { controller = "Projects", action = "GetProject" });
                routes.MapRoute(
                    name: "Home",
                    template: "{language=en}/{action=Index}",
                    defaults: new { controller = "Home" }
                );
            });
        }
    }
}
