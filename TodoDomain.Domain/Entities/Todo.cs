
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Todo : Entity<Todo>
{
    public required override Identifier<Todo> Id { get; init; }
    public required Descriptor Description { get; init; }
    public required TodoDates TodoDates { get; init; }
    public required override EntityDates EntityDates { get; init; }
    public IEnumerable<Tag> Tags { get; init; } = [];
    public IEnumerable<Category> Categories { get; init; } = [];

    private Todo(string description, DateOnly? dueDate)
    {
        if (string.IsNullOrEmpty(description))
        {
            throw new ArgumentException($"{nameof(description)} is required", nameof(description));
        }
        else if (description.Length > 255)
        {
            throw new ArgumentException($"{nameof(description)} must be 255 characters or fewer", nameof(description));
        }
        else
        {
            Id = new Identifier<Todo>(Guid.NewGuid());
            Description = new Descriptor(description);
            TodoDates = new TodoDates(dueDate, null);
            EntityDates = new EntityDates(DateTimeOffset.UtcNow, null);
        }
    }
}
