
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Tag : Entity<Tag>
{
    public override Identifier<Tag> Id { get; init; }
    public Descriptor Name { get; init; }
    public DateTimeOffset CreateDate { get; init; }
    public DateTimeOffset? UpdateDate { get; init; }
    public IEnumerable<Todo> Todos { get; init; } = [];
}
