using CleanArquitecture.Application.Interfaces;
using CleanArquitecture.Application.Services;
using CleanArquitecture.Domain.Interfaces;
using CleanArquitecture.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArquitecture.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<ICarroService, CarroService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<ICarroRepository, CarroRepository>();
        }
    }
}
