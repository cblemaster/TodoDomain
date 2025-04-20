
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Category : Entity<Category>
{
    public required override Identifier<Category> Id { get; init; }
    public required Descriptor Name { get; init; }
    public required override EntityDates EntityDates { get; init; }
    public IEnumerable<Todo> Todos { get; init; } = [];
}
