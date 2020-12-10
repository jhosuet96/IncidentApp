using IncidentApp.Model;
using IncidentApp.Repository.GenericRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace InsidentApp
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
            services.AddMvcCore().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonFormatters();
            
            //Importante 1
            services.AddCors(options =>
            {
                options.AddPolicy(
                   name: "AllowOrigin",
                   builder => {
                       builder.AllowAnyOrigin()
                      .AllowAnyMethod().AllowAnyMethod()
                      .AllowAnyHeader().WithOrigins("http://localhost:4200");
                   });
            });

            services.AddDbContext<IncidentAppContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("IncidentApp")));

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
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
                app.UseHsts();//.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors("AllowOrigin");
            app.UseMvc();

            //Importante 2
        }
    }
}
