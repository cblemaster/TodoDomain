
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public abstract class Entity<T>
{
    public required abstract Identifier<T> Id { get; init; }
    public abstract EntityDates EntityDates { get; protected set; }
}
