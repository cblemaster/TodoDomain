
namespace TodoDomain.Domain.Entities;

public sealed class Category : Entity<Category>
{
    public override Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public DateTimeOffset CreateDate { get; init; }
    public DateTimeOffset? UpdateDate { get; init; }
    public IEnumerable<Todo> Todos { get; init; } = [];
}
