using Domain.Core.Base;
using Domain.Core.Catalogs.Features;

namespace Domain.Core.Catalogs.Categories;

public class CategoryRoot : AggregateRoot<CategoryId>
{
    public CategoryId CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Type { get; private set; }
    public bool IsActive { get; set; }
    public string Description { get; set; }
    public IReadOnlyList<Feature> Features => _features;
    private readonly List<Feature> _features = new();

    internal static CategoryRoot CreateNew(string CategoryName, string Type, bool IsActive, string Description,List<FeatureData> datas)
    {
        return new CategoryRoot(CategoryName, Type, IsActive, Description,datas);
    }
    private CategoryRoot(){}

    private void BuildFeatures(List<FeatureData> featureDatas)
    {
        featureDatas.ForEach(item =>
        {
            
            var newFeature = Feature.CreateNew(item.Title, item.Description, item.SortOrder);
            _features.Add(newFeature);
            
        });
    }
    private CategoryRoot(string CategoryName, string Type, bool IsActive, string Description,List<FeatureData> datas) 
    {
        this.CategoryName = CategoryName;
        this.Type = Type;
        this.IsActive = IsActive;
        this.Description = Description;
    }
}