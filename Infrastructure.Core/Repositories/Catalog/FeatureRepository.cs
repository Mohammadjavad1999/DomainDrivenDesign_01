using Domain.Core.Catalogs.Features;
using Infrastructure.Data.Context;
using Infrastructure.Data.Exceptions;

namespace Infrastructure.Core.Repositories.Catalog;

public class FeatureRepository:IFeatureRepository
{
    private CommerceContext _dbCtx { get; }
    public FeatureRepository(CommerceContext dbCtx)
    {
        _dbCtx = dbCtx;
    }
    public async Task<FeatureId> Insert(Feature feature)
    {
      await _dbCtx.Features.AddAsync(feature);

      return feature.Id;
    }

    public async Task Update(Feature feature)
    {
        var currentFeature =await _dbCtx.Features.FindAsync(feature.Id);
        if (feature==null)
        {
            throw new dbException("FEATURE IS NOT VALID");
        }
        currentFeature.Update(feature.Title,feature.Description,feature.SortOrder); 
        throw new NotImplementedException();
    }

    public async Task<Feature> GetById(FeatureId featureId)
    {
        
        var feature =await _dbCtx.Features.FindAsync(featureId);
        if (feature==null)
        {
            throw new dbException("FEATURE IS NOT VALID");
        }

        
        
        return feature;
    }

    public void Delete(FeatureId featureId)
    {
        var feature = Feature.CreateNewForDelete(featureId);
        _dbCtx.Features.Remove(feature);
    }
}