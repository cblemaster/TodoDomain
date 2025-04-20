
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Category : Entity<Category>
{
    public required override Identifier<Category> Id { get; init; }
    public required Descriptor Name { get; init; }
    public required override EntityDates EntityDates { get; init; }
    public IEnumerable<Todo> Todos { get; init; } = [];

    private Category(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"{nameof(name)} is required", nameof(name));
        }
        else if (name.Length > 40)
        {
            throw new ArgumentException($"{nameof(name)} must be 40 characters or fewer", nameof(name));
        }
        else
        {
            Id = new Identifier<Category>(Guid.NewGuid());
            Name = new Descriptor(name);
            EntityDates = new EntityDates(DateTimeOffset.UtcNow, null);
        }
    }
}
