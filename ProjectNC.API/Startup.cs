using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ProjectNC.Domain.Middlewares;
using ProjectNC.Domain.Profiles;
using ProjectNC.Infrastructure.Data;

namespace ProjectNC.API
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
            //Add SQL Server and Context on Builds
            services.AddEntityFrameworkSqlServer();
            services.AddDbContextPool<AppDbContext>((services, options) =>
            {
                options.UseInternalServiceProvider(services);
                options.UseSqlServer(Configuration.GetConnectionString("ApplicationConnectionString"));
            });

            //Add Automapper and Configurations
            var mappingConfig = new MapperConfiguration(mc =>
             {
                 mc.AddProfile(new OrderProfile());
                 mc.AddProfile(new CategoryProfile());
                 mc.AddProfile(new OfferProfile());
                 mc.AddProfile(new DeliveryProfile());
                 mc.AddProfile(new PaymentProfile());
                 mc.AddProfile(new ClientProfile());
                 mc.AddProfile(new ClientDeliveryProfile());
                 mc.AddProfile(new ClientBillingProfile());
                 mc.AddProfile(new ProductOrderProfile());
                 mc.AddProfile(new ProductProfile());
                 mc.AddProfile(new RoleProfile());
                 mc.AddProfile(new SubCategoryProfile());
                 mc.AddProfile(new UserProfile());
                 mc.AddProfile(new RoleProfile());
                 mc.AddProfile(new OrderProfile());
                 mc.AddProfile(new CommentProductProfile());
                 mc.AddProfile(new ImageProfile());
                 mc.AddProfile(new NoveltyProfile());

             });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //Add Controllers
            services.AddControllers();

            //Add Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjectNC.API", Version = "v1" });
            });

            //Add Dependencies


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjectNC.API v1"));
            }

            // Middleware de handeleo de excepciones global
            app.UseMiddleware<ExceptionHandlerMiddleware>();

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
