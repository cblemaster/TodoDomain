
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Category(string name) : Attribute<Category>(name, NAME_MAX_LENGTH)
{
    private const int NAME_MAX_LENGTH = 40;

    public required Identifier<Category> CategoryId { get; init; } =
        new Identifier<Category>(Guid.NewGuid());
}
