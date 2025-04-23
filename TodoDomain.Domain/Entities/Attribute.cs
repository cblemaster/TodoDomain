
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public class Attribute<T> : Entity<Attribute<T>>
{
    private readonly int _maxLength;

    public override required Identifier<Attribute<T>> Id { get; init; }
    public Descriptor Name { get; private set; }
    public override EntityDates EntityDates { get; protected set; }
    public IEnumerable<Todo> Todos { get; init; } = [];

    protected Attribute(string name, int maxLength)
    {
        _maxLength = maxLength;
        ValidateNameOrThrow(name);
        Id = new Identifier<Attribute<T>>(Guid.NewGuid());
        Name = new Descriptor(name);
        EntityDates = new EntityDates(DateTimeOffset.UtcNow, null);
    }

    public void Rename(string name)
    {
        ValidateNameOrThrow(name);
        Name = Name with { Value = name };
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }

    public bool CanDelete() => !Todos.Any();

    private void ValidateNameOrThrow(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"{nameof(name)} is required", nameof(name));
        }
        else if (name.Length > _maxLength)
        {
            throw new ArgumentException($"{nameof(name)} must be  {_maxLength}  characters or fewer", nameof(name));
        }
    }
}
