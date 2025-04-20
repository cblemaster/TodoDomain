
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Tag : Entity<Tag>
{
    public override Identifier<Tag> Id { get; init; }
    public Descriptor Name { get; init; }
    public override EntityDates EntityDates { get; init; }
    public IEnumerable<Todo> Todos { get; init; } = [];
}
