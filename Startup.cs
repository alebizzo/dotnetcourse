using dotnetcourse.Models.Services.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace dotnetcourse
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<ICourseService, CourseService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            // middleware per la gestione delle eccezioni (solo sviluppo)
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // middleware per i file statici
            app.UseStaticFiles();

            // middleware di routing
            app.UseMvc(routeBuilder => {
                routeBuilder.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
