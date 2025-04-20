
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Tag : Entity<Tag>
{
    public required override Identifier<Tag> Id { get; init; }
    public required Descriptor Name { get; init; }
    public required override EntityDates EntityDates { get; init; }
    public IEnumerable<Todo> Todos { get; init; } = [];

    private Tag(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"{nameof(name)} is required", nameof(name));
        }
        else if (name.Length > 20)
        {
            throw new ArgumentException($"{nameof(name)} must be 20 characters or fewer", nameof(name));
        }
        else
        {
            Id = new Identifier<Tag>(Guid.NewGuid());
            Name = new Descriptor(name);
            EntityDates = new EntityDates(DateTimeOffset.UtcNow, null);
        }
    }
}
