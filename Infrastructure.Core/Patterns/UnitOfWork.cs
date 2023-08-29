using Infrastructure.Data.Context;

namespace Infrastructure.Core.Patterns;

public class UnitOfWork:IUnitOfWork
{
    private CommerceContext _ctx { get; }
    public UnitOfWork(CommerceContext ctx)
    {
        _ctx = ctx;
    }


    public void Dispose()
    {
        _ctx.Dispose();
    }

    public void SaveChanges()
    {
        _ctx.SaveChanges();
    }

    public async Task SaveChangesAsync()
    {
       await _ctx.SaveChangesAsync();
    }
}