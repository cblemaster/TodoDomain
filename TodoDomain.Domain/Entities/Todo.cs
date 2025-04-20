
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Todo : Entity<Todo>
{
    public override Identifier<Todo> Id { get; init; }
    public Descriptor Description { get; init; }
    public TodoDates TodoDates { get; init; }
    public override EntityDates EntityDates { get; init; }
    public IEnumerable<Tag> Tags { get; init; } = [];
    public IEnumerable<Category> Categories { get; init; } = [];
}
