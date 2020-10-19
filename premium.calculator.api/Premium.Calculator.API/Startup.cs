using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Premium.Calculator.Persistence.Contexts.PremiumCalculator;
using Premium.Calculator.Persistence.Repositories;
using CustomerRepo = Premium.Calculator.Persistence.Repositories.Customer;
using OccupationRepo = Premium.Calculator.Persistence.Repositories.Occupation;
using OccupationRatingRepo = Premium.Calculator.Persistence.Repositories.OccupationRating;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using FluentValidation;
using FluentValidation.AspNetCore;
using Premium.Calculator.API.Filters;
using MediatR;
using Premium.Calculator.Application.Customers;

namespace API
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
            // ReferenceLoopHandling setting to Newtonsoft.Json to fix an issue with Dotnet core 3.0 which throws exception with Nested entities
            services.AddControllers().AddNewtonsoftJson(options =>
                { options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
                    options.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
                    if (options.SerializerSettings.ContractResolver != null)
                    {
                        var CastResolver = options.SerializerSettings.ContractResolver as DefaultContractResolver;
                        CastResolver.NamingStrategy = null;
                    }
                    options.SerializerSettings.Formatting = Formatting.Indented;
                }
            );

            services
                .AddMvc(options => {
                    //options.EnableEndpointRouting = false;
                    options.Filters.Add<ValidationFilter>();
                })
                .AddFluentValidation(mvcConfiguration => mvcConfiguration.RegisterValidatorsFromAssemblyContaining<Startup>())
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddDbContext<PremiumCalculatorDbContext>(opt =>
            {
                // Using sqLite as a data source for this test.
                string strConnectionString = Configuration.GetConnectionString("PremiumCalcConnection");
                opt.UseSqlite(strConnectionString);
            });

            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:5000/");
                });
            });
            services.AddMediatR(typeof(List.Handler).Assembly);
            services.AddControllers();
            services.AddTransient<IUnitOfWork, UnitOfWork>();            
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<CustomerRepo.ICustomerRepository, CustomerRepo.CustomerRepository>();
            services.AddTransient<OccupationRepo.IOccupationRepository, OccupationRepo.OccupationRepository>();
            services.AddTransient<OccupationRatingRepo.IOccupationRatingRepository, OccupationRatingRepo.OccupationRatingRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors("CorsPolicy");
        }
    }
}
