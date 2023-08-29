using Application.Contract.Dto.Catalog;
using Application.Contract.Interfaces.Catalog;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Catalog;

[Route("api/[controller]")]
[ApiController]
public class FeaturesController : ControllerBase
{
    protected IFeatureService _featureService { get; }

    public FeaturesController(IFeatureService featureService)
    {
        _featureService = featureService;
    }

    // POST
    [HttpPost]
    public async Task<IActionResult> Post(FeatureDto model)
    {
        await _featureService.Add(model);
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _featureService.GetById(id);
        return Ok(result);
    }
}