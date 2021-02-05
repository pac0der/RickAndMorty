using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RickAndMorty.Characters.Framework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Characters.Framework.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCharacterFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICharacterService, CharacterService>();
            return services;
        }
    }
}
