
namespace TodoDomain.Domain.Entities;

public sealed class Todo : Entity<Todo>
{
    public override Guid Id { get; init; }
    public string Description { get; init; } = string.Empty;
    public DateTimeOffset? DueDate { get; init; }
    public DateTimeOffset? CloseDate { get; init; }
    public DateTimeOffset CreateDate { get; init; }
    public DateTimeOffset? UpdateDate { get; init; }
    public IEnumerable<Tag> Tags { get; init; } = [];
    public IEnumerable<Category> Categories { get; init; } = [];
}
