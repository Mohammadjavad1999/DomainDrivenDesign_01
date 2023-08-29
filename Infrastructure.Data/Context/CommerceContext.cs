using Domain.Core.Catalogs.Categories;
using Domain.Core.Catalogs.Features;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context;
public class CommerceContext:DbContext
{
    public DbSet<Feature> Features { get; set; }
    public DbSet<CategoryRoot> Categories { get; set; }
  
    
}