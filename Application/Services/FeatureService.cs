using Application.Contract.Dto.Catalog;
using Application.Contract.Interfaces.Catalog;
using Domain.Core.Catalogs.Features;
using Infrastructure.Core.Patterns;

namespace Application.Services;

public class FeatureService : IFeatureService
{
    private IUnitOfWork _context { get; }
    private IFeatureRepository _featureRepo { get; }

    public FeatureService(IUnitOfWork context, IFeatureRepository featureRepo)
    {
        _context = context;
        _featureRepo = featureRepo;
    }

    public Task<List<FeatureDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<FeatureDto> GetById(Guid id)
    {
        var feature = await _featureRepo.GetById(new FeatureId(id));
        return new FeatureDto()
        {
            Id = id,
            Title = feature.Title,
            Description = feature.Description,
            SortOrder = feature.SortOrder

        };
        
     
    }

    public async Task Add(FeatureDto model)
    {
     
        var feature = Feature.CreateNew(model.Title, model.Description, model.SortOrder);
        await _featureRepo.Insert(feature);
        await _context.SaveChangesAsync();

        //Insert To Db
        //1.Call Repo
        //Create DbContext
    }

    public async Task Edit(FeatureDto model)
    {
        var feature = Feature.Update(model.Id, model.Title, model.Description, model.SortOrder);
        await _featureRepo.Update(feature);
        await _context.SaveChangesAsync();
    }

    public async Task Remove(Guid id)
    {
        _featureRepo.Delete(new FeatureId(id));
        await _context.SaveChangesAsync();
    }
}