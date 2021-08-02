using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PolicyAdmin.QuotesMS.API.Data;
using PolicyAdmin.QuotesMS.API.Repository;
using PolicyAdmin.QuotesMS.API.DataLayer;
using PolicyAdmin.QuotesMS.API.Services;
using PolicyAdmin.QuotesMS.API.Interface;

namespace PolicyAdmin.QuotesMS.API
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
            if (Configuration.GetValue<bool>("InMemoryDatabase"))
            {
                services.AddDbContext<QuotesContext>(options => options.UseInMemoryDatabase("PolicyAdmin_Quotes"));
               
            }
            else
            {
                services.AddDbContext<QuotesContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Database")));
            }

            services.AddTransient<IQuotesDBService,QuotesDBService>();
            services.AddTransient<IQuoteRepository,QuoteRepository>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PolicyAdmin.QuotesMS.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PolicyAdmin.QuotesMS.API v1"));
            }
            if (Configuration.GetValue<bool>("inmemorydatabase"))
            {
                var scopeeee = app.ApplicationServices.CreateScope();
                var context = scopeeee.ServiceProvider.GetRequiredService<QuotesContext>();
                DataGenerator.Initialize(context);

            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
