
using TodoDomain.Domain.ValueObjects;

namespace TodoDomain.Domain.Entities;

public sealed class Todo : Entity<Todo>
{
    private const int DESCRIPTION_MAX_LENGTH = 255;

    public required override Identifier<Todo> Id { get; init; }
    public Descriptor Description { get; private set; }
    public TodoDates TodoDates { get; private set; }
    public override EntityDates EntityDates { get; protected set; }
    public IEnumerable<Tag> Tags { get; private set; } = [];
    public IEnumerable<Category> Categories { get; private set; } = [];

    public Todo(string description, DateOnly? dueDate)
    {
        ValidateDescriptionOrThrow(description);
        Id = new Identifier<Todo>(Guid.NewGuid());
        Description = new Descriptor(description);
        TodoDates = new TodoDates(dueDate, null);
        EntityDates = new EntityDates(DateTimeOffset.UtcNow, null);
    }

    public void UpdateDescription(string description)
    {
        if (TodoDates.CompleteDate is null)
        {
            ValidateDescriptionOrThrow(description);
            Description = Description with { Value = description };
            EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
        }
        // TODO: domain cannot update complete todos exception
    }
    public void UpdateDueDate(DateOnly? dueDate)
    {
        if (TodoDates.CompleteDate is null)
        {
            TodoDates = TodoDates with { DueDate = dueDate };
            EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
        }
    }
    public void ToggleComplete(bool isComplete)
    {
        TodoDates = isComplete
            ? (TodoDates with { CompleteDate = DateTimeOffset.UtcNow })
            : (TodoDates with { CompleteDate = null });
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }

    public void AddTag(Tag tag)
    {
        Tags = Tags.Append(tag);
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }
    public void RemoveTag(Tag tag)
    {
        Tags = Tags.Where(t => t.Id != tag.Id);
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }
    public void AddCategory(Category category)
    {
        Categories = Categories.Append(category);
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }
    public void RemoveCategory(Category category)
    {
        Categories = Categories.Where(c => c != category);
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }
    public void AddTags(IEnumerable<Tag> tags)
    {
        Tags = Tags.Concat(tags);
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }
    public void RemoveTags(IEnumerable<Tag> tags)
    {
        Tags = Tags.Except(tags);
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }
    public void AddCategories(IEnumerable<Category> categories)
    {
        Categories = Categories.Concat(categories);
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }
    public void RemoveCategories(IEnumerable<Category> categories)
    {
        Categories = Categories.Except(categories);
        EntityDates = EntityDates with { UpdateDate = DateTimeOffset.UtcNow };
    }

    private static void ValidateDescriptionOrThrow(string description)
    {
        if (string.IsNullOrEmpty(description))
        {
            throw new ArgumentException($"{nameof(description)} is required", nameof(description));
            // TODO: domain validation exception
        }
        else if (description.Length > DESCRIPTION_MAX_LENGTH)
        {
            throw new ArgumentException($"{nameof(description)} must be  {DESCRIPTION_MAX_LENGTH}  characters or fewer", nameof(description));
            // TODO: domain validation exception
        }
    }
}
