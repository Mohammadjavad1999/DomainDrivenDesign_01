namespace Domain.Core.Base;

public abstract class AggregateRoot<TKey>:Entity<TKey>,IAggregateRoot
{
    private List<IDomainEvent> _domainEvents;
    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents?.AsReadOnly();

    protected void AddDomainEvents(IDomainEvent domainEvent)
    {
        _domainEvents = _domainEvents ?? new List<IDomainEvent>();
        _domainEvents.Add(domainEvent);
    }
    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}