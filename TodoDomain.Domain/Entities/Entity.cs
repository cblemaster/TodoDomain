
namespace TodoDomain.Domain.Entities;

public abstract class Entity<T>
{
    public abstract Guid Id { get; init; }
}
