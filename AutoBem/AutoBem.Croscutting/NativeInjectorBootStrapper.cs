using AutoBem.Application.AutoMapper;
using AutoBem.Application.Contracts;
using AutoBem.Application.Services;
using AutoBem.Domain.Contracts.Repositories;
using AutoBem.Domain.Contracts.Services;
using AutoBem.Domain.Entities;
using AutoBem.Domain.Services;
using AutoBem.Repository.Context;
using AutoBem.Repository.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutoBem.Croscutting
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            #region [Configuration]

            var connection = configuration["CONNECTION_STRING:MySQL"];
            services.AddDbContext<AutoBemContext>
                (options =>
                    options.UseMySql(connection, ServerVersion.AutoDetect(connection))
                );
            services.AddScoped<AutoBemContext, AutoBemContext>();

            #endregion

            services.AddScoped(typeof(IDomainService<>), typeof(DomainService<>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IProprietarioApplication, ProprietarioApplication>();
            services.AddScoped<IVeiculoApplication, VeiculoApplication>();
            services.AddScoped<IRepository<Proprietario>, ProprietarioRepository>();
            services.AddScoped<IRepository<Veiculo>, VeiculoRepository>();

            //Configuration AutoMapping
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}