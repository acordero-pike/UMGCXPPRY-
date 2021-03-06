using cxp.Data;
using cxp.Interfaces;
using cxp.Services;

using Microsoft.AspNetCore.Authentication.Cookies;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cxp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddServerSideBlazor();
          
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<ITipoProductoService, TipoProductoService>();

            services.AddScoped<IPedidoService, PedidoService>();

            services.AddScoped<IPedidoDetalleService, PedidoDetalleService>();

            services.AddScoped<FileUtil>();
            services.AddScoped<IProveedorService, ProveedorService>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            services.AddScoped<IPedidoPago, PedidopagarServicecs>();
            services.AddScoped<IRecepcion, RecepcionServicio>();
    
            services.AddScoped<ILogin, LoginService>();
            services.AddScoped<IAbono, Abonoservices>();

            var sqlConnectionConfiguration = new SqlConfiguration(Configuration.GetConnectionString("SqlConnection"));

            services.AddSingleton(sqlConnectionConfiguration);
            
             services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            // ******
            // BLAZOR COOKIE Auth Code (begin)
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
 