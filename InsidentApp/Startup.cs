using IncidentApp.Model;
using IncidentApp.Repository.GenericRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            //services.AddDbContext<IncidentAppContext>(options =>
            //{
            //    options.UseSqlServer("Server=DESKTOP-2TE51VC;Database=IncidentApp;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("InsidentApp"));
            //});

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

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline. https://localhost:44368
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
