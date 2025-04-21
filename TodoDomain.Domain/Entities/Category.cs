
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Category : Entity<Category>
{
    private const int NAME_MAX_LENGTH = 40;

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
        else if (name.Length > NAME_MAX_LENGTH)
        {
            throw new ArgumentException($"{nameof(name)} must be  {NAME_MAX_LENGTH}  characters or fewerer", nameof(name));
        }
        else
        {
            Id = new Identifier<Category>(Guid.NewGuid());
            Name = new Descriptor(name);
            EntityDates = new EntityDates(DateTimeOffset.UtcNow, null);
        }
    }
}
