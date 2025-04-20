
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Tag : Entity<Tag>
{
    public override Identifier<Tag> Id { get; init; }
    public Descriptor Name { get; init; }
    public override DateTimeOffset CreateDate { get; init; }
    public override DateTimeOffset? UpdateDate { get; init; }
    public IEnumerable<Todo> Todos { get; init; } = [];
}
