
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public abstract class Entity<T>
{
    public abstract Identifier<T> Id { get; init; }
    public abstract DateTimeOffset CreateDate { get; init; }
    public abstract DateTimeOffset? UpdateDate { get; init; }
}
