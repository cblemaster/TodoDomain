
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Category : Entity<Category>
{
    public override Identifier<Category> Id { get; init; }
    public Descriptor Name { get; init; }
    public override EntityDates EntityDates { get; init; }
    public IEnumerable<Todo> Todos { get; init; } = [];
}
