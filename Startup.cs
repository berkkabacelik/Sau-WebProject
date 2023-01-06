using System.Reflection.PortableExecutable;
using System.Net;
using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace MovieApp
{
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app , IHostingEnvironment env)
        {
                       
            app.UseStaticFiles(); //wwwroot klasörü dışarıya açılmış oldu

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                RequestPath = "/modules"
            });
            

            //modules/bootstrap/dist/css/bootstrap.min.css
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //home/index/3
            app.UseMvcWithDefaultRoute();
           
        }
    }
}
