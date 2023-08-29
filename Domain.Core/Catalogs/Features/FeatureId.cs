using Domain.Core.Base;

namespace Domain.Core.Catalogs.Features;

public sealed class FeatureId:StronglyTypedId<Guid>
{
    public FeatureId(Guid value) : base(value)
    {
    }
}