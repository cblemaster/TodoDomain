
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Todo : Entity<Todo>
{
    public override Identifier<Todo> Id { get; init; }
    public Descriptor Description { get; init; }
    public DateOnly? DueDate { get; init; }
    public DateTimeOffset? CloseDate { get; init; }
    public DateTimeOffset CreateDate { get; init; }
    public DateTimeOffset? UpdateDate { get; init; }
    public IEnumerable<Tag> Tags { get; init; } = [];
    public IEnumerable<Category> Categories { get; init; } = [];
}
