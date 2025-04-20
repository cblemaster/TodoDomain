
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public abstract class Entity<T>
{
    public abstract Identifier<T> Id { get; init; }
}
