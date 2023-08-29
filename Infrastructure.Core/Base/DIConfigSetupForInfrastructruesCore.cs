using Domain.Core.Catalogs.Features;
using Infrastructure.Core.Patterns;
using Infrastructure.Core.Repositories.Catalog;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Core.Base;

public static class DIConfigSetupForInfrastructruesCore
{
    public static void RepositorySetup(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IFeatureRepository, FeatureRepository>();


    }
}