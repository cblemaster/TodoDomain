
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Tag(string name) : Attribute<Tag>(name, NAME_MAX_LENGTH)
{
    private const int NAME_MAX_LENGTH = 20;

    public required Identifier<Tag> TagId { get; init; }
        = new Identifier<Tag>(Guid.NewGuid());
}
