
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public abstract class Entity<T>
{
    public required abstract Identifier<T> Id { get; init; }
    public required abstract EntityDates EntityDates { get; init; }
}
