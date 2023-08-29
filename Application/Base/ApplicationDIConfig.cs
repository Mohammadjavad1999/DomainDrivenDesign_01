using Application.Contract.Interfaces.Catalog;
using Application.Services;
using Domain.Core.Catalogs.Features;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Base;

public static class ApplicationDIConfig
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IFeatureService, FeatureService>(); 

    }
}