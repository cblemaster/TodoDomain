
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Tag : Entity<Tag>
{
    private const int NAME_MAX_LENGTH = 20;

    public required override Identifier<Tag> Id { get; init; }
    public Descriptor Name { get; private set; }
    public required override EntityDates EntityDates { get; init; }
    public IEnumerable<Todo> Todos { get; init; } = [];

    public Tag(string name)
    {
        ValidateNameOrThrow(name);
        Id = new Identifier<Tag>(Guid.NewGuid());
        Name = new Descriptor(name);
        EntityDates = new EntityDates(DateTimeOffset.UtcNow, null);
    }

    public void Rename(string name)
    {
        ValidateNameOrThrow(name);
        Name = Name with { Value = name };
    }

    public bool CanDelete() => !Todos.Any();
    private static void ValidateNameOrThrow(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"{nameof(name)} is required", nameof(name));
        }
        else if (name.Length > NAME_MAX_LENGTH)
        {
            throw new ArgumentException($"{nameof(name)} must be  {NAME_MAX_LENGTH}  characters or fewerer", nameof(name));
        }
    }
}
