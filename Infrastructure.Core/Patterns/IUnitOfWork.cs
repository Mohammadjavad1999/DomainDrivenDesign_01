namespace Infrastructure.Core.Patterns;

public interface IUnitOfWork:IDisposable
{
    void SaveChanges();
    Task SaveChangesAsync();

}