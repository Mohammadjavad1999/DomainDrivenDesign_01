using Domain.Core.Catalogs.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

internal sealed class CategoryConfig:IEntityTypeConfiguration<CategoryRoot>
{
    public void Configure(EntityTypeBuilder<CategoryRoot> builder)
    {
        builder.ToTable("Categories", "Catalog");
        builder.HasKey(k => k.CategoryId);
        builder.Property(x => x.Id)
            .HasConversion(v => v.Value,
                v => new CategoryId(v));


    }
}