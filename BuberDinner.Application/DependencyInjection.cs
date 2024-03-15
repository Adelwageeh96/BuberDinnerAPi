using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using MediatR;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BuberDinner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
