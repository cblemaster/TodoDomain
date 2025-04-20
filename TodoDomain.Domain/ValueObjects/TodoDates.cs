
namespace TodoDomain.Domain.ValueObjects;

public record struct TodoDates(DateOnly? DueDate, DateTimeOffset? CloseDate);
