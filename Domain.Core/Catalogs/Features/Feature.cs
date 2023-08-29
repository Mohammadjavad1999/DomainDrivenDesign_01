using Domain.Core.Base;

namespace Domain.Core.Catalogs.Features;

public class Feature : AggregateRoot<FeatureId>
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int SortOrder { get; set; }

    public void Update(string Title, string description, int sortOrder)
    {
        Title = Title;
        Description = description;
        SortOrder = sortOrder;
    }

    public static Feature Update(Guid id, string title, string description, int sortOrder)
    {
        
        return new Feature(new FeatureId(id),title,description,sortOrder);
    }
    public static Feature CreateNewForDelete(FeatureId id)
    {
        return new Feature(id);
    }
    public static Feature CreateNew(string Title, string Description, int sorOrder)
    {
        return new Feature(Title, Description, sorOrder);
    }

    private Feature()
    {
    }

    private Feature(FeatureId id)
    {
        var feature = Feature.CreateNewForDelete(id);
        

    }

    private Feature(FeatureId id, string title, string description, int sortOrder)
    {
        Id = id;
        Title = title;
        Description = description;
        SortOrder = sortOrder;
    }
    private Feature(string Title, string description, int sortOrder)
    {
        //Validation With Invariant and Custom Exceptions  then=>
        this.Title = Title;
        this.Description = description;
        this.SortOrder = sortOrder;
    }
}