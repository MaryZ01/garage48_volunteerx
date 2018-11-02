using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolunteerX.Services;

namespace VolunteerX.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddGenericRepostiory(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
