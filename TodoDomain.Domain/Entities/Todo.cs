
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Todo : Entity<Todo>
{
    public required override Identifier<Todo> Id { get; init; }
    public required Descriptor Description { get; init; }
    public TodoDates TodoDates { get; init; }
    public required override EntityDates EntityDates { get; init; }
    public IEnumerable<Tag> Tags { get; init; } = [];
    public IEnumerable<Category> Categories { get; init; } = [];
}
