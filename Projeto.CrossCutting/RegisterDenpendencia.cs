using Microsoft.Extensions.DependencyInjection;
using Projeto.infra.Ropositories;
using Projeto.infra.Ropositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.CrossCutting
{
    public class RegisterDenpendencia
    {
        private static IServiceCollection _serviceDescriptors { get; set; }
        public static void Register(IServiceCollection services)
        {

            services.AddScoped<IDividaRepository, DividaRepository>();
            services.AddScoped<IParcelasRepository, ParcelasRepository>();
            services.AddScoped<ITituloAtrasoRepository, TitulosAtrasoRepository>();


            _serviceDescriptors = services;

        }

        public static TService GetService<TService>()
        {
            return (TService)_serviceDescriptors.FirstOrDefault().ImplementationInstance;
        }




    }
}
