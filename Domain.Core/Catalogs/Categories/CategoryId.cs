using Domain.Core.Base;

namespace Domain.Core.Catalogs.Categories;

public sealed class CategoryId:StronglyTypedId<CategoryId>
{
    public CategoryId(Guid value):base(value)
    {}

 
    protected override int GetHashCodeCore()
    {
        throw new NotImplementedException();
    }
}